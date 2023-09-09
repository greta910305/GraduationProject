using UnityEngine;
public class MusicControl : MonoBehaviour
{
    private AudioSource audioSource;//���q�ƭ�
    private bool muteState;//�P�_�O�_���R��
    private float preVolume;//�����R���e���q
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0;
        muteState = false;
        preVolume = audioSource.volume;
    }
    public void VolumeChanged(float newVolume)
    {
        audioSource.volume = newVolume;
        muteState = false;
    }
    public void MuteClick()
    {
        muteState = !muteState;
        if (muteState)
        {
            preVolume = audioSource.volume;
            audioSource.volume = 0;
        }
        else
            audioSource.volume = preVolume;
    }
}