using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
[SerializeField] private AudioMixer _music;
[SerializeField] private Slider _musicslider;

public void SetMusicVolume()
{
    float volume = _musicslider.value;
    _music.SetFloat("Music", Mathf.Log10(volume) * 20);
}
}
