using UnityEngine;

namespace Junya005.SoundEngine.Sample
{
    public class SoundEngineTest : MonoBehaviour
    {
        void Start()
        {
            SoundEngine.Instance.PlayBGM("lofi_0");
        }

        public void OnClicked()
        {
            SoundEngine.Instance.PlaySE("se_next");
        }
    }
}
