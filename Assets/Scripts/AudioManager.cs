using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioMixer audioMixer;

    public void ChangeVolumeMaster(float volume) {
        audioMixer.SetFloat("VolMaster", volume);
    }
    public void ChangeVolumeFX(float volume) {
        audioMixer.SetFloat("VolFX", volume);
    }
}
