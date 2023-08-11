using UnityEngine;

namespace DVR.Classes.Sound {
    [System.Serializable]
    public class Sound {
        public enum AudioTypes { SFX, MUSIC }

        public AudioTypes AudioType;
        public string Name;
        public AudioClip Clip;
        [Range(0f, 1f)]
        public float Volume;
        [Range(0.1f, 3f)]
        public float Pitch;
        public bool Loop;
        public bool PlayOnAwake;
        [HideInInspector] public AudioSource Source;
    }
}
