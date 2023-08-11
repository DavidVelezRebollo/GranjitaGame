using Granjita.Classes.Characters;
using Granjita.Shared;
using Granjita.Interfaces;

using UnityEngine;

namespace Granjita.Components.Characters {
    public class CharacterComponent : MonoBehaviour, ICombatable {
        [SerializeField] private Character CharacterInfo;

        public float GetSpeed() {
            return CharacterInfo.CurrentClass.InitialClassStats.GetSpeed();
        }
    }
}
