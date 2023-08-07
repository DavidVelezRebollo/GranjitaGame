using Granjita.Shared;

using UnityEngine;

namespace Granjita.Classes.Characters {
    [CreateAssetMenu(fileName = "Character", menuName = "Game/Character")]
    public class Character : ScriptableObject {
        [SerializeField] private string Name;
        [SerializeField] private Classes CurrentClass;
    }
}
