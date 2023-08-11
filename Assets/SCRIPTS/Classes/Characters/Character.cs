using Granjita.Shared;

using UnityEngine;

namespace Granjita.Classes.Characters {
    [CreateAssetMenu(fileName = "Character", menuName = "Game/Character")]
    public class Character : ScriptableObject {
        public string Name;
        public Classes CurrentClass;
    }
}
