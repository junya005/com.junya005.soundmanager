using System.Collections.Generic;
using UnityEngine;

namespace Junya005.SoundEngine
{
    [CreateAssetMenu(fileName = "AudioData", menuName = "Junya005/SoundEngine/AudioData")]
    public class SOAudioData : ScriptableObject
    {
        [Header("Set BGM AudioClip Here")]
        public List<AudioClip> BGMList;

        [Header("Set SE AudioClip Here")]
        public List<AudioClip> SEList;
    }
}
