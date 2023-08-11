using UnityEngine;

namespace Granjita.Components.Core {
    public class GameManager : MonoBehaviour {
        public static GameManager Instance;

        private void Awake() {
            if(Instance != null) return;

            Instance = this;
        }
    }
}
