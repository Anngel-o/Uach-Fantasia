using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volMaster;
    public Slider volFX;
    public AudioSource fxaudioSource;
    public AudioClip clickAudio;
    public Toggle mute;
    private float lastVolume;

    void Awake()
    {
        volFX.onValueChanged.AddListener(ChangeVolumeFX);
        volMaster.onValueChanged.AddListener(ChangeVolumeMaster);
    }

    public void SetMute()
    {
        
        if (mute.isOn){
            audioMixer.GetFloat("VolMaster", out lastVolume);
            audioMixer.SetFloat("VolMaster", -80);
        }
        else
            audioMixer.SetFloat("VolMaster", lastVolume);
        PlayClick();
    }

    public void ChangeVolumeMaster(float volume)
    {
        audioMixer.SetFloat("VolMaster", volume);
    }
    public void ChangeVolumeFX(float volume)
    {
        audioMixer.SetFloat("VolFX", volume);
    }

    public void PlayClick()
    {
        fxaudioSource.PlayOneShot(clickAudio);
    }
}
