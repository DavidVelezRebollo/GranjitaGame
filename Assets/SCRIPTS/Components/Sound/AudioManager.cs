using DVR.Classes.Sound;

using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioMixerGroup GeneralMixerGroup;
    [SerializeField]
    private AudioMixerGroup MusicMixerGroup;
    [SerializeField]
    private AudioMixerGroup SoundsEffectsMixerGroup;
    [SerializeField]
    private Sound[] Sounds;

    public static AudioManager Singleton;

    private void Awake() {
        if (Singleton == null)
            Singleton = this;

        foreach(Sound s in Sounds) {
            s.Source = gameObject.AddComponent<AudioSource>();
            s.Source.clip = s.Clip;

            s.Source.volume = s.Volume;
            s.Source.pitch = s.Pitch;

            if (s.AudioType == Sound.AudioTypes.SFX)
                s.Source.outputAudioMixerGroup = SoundsEffectsMixerGroup;
            else if (s.AudioType == Sound.AudioTypes.MUSIC)
                s.Source.outputAudioMixerGroup = MusicMixerGroup;

            if (s.PlayOnAwake)
                s.Source.Play();
        }
    }

    public void Play(string name) {
        Sound s = Array.Find(Sounds, sound => sound.Name == name);
        if(s == null) {
            Debug.LogError("Sound " + name + " not found!");
            return;
        }

        s.Source.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(Sounds, sound => sound.Name == name);
        if (s == null) {
            Debug.LogError("Sound " + name + " not found!");
            return;
        }

        s.Source.Stop();
    }

    /*
    public void UpdateMixerVolume()
    {
        GeneralMixerGroup.audioMixer.SetFloat("GeneralVolume", SettingsMenu.generalVolume);
        SoundsEffectsMixerGroup.audioMixer.SetFloat("SoundEffects", SettingsMenu.soundEffectsVolume);
        MusicMixerGroup.audioMixer.SetFloat("Music", SettingsMenu.musicVolume);
    }
    */
}
