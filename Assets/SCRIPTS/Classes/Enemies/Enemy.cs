using Granjita.Shared;

using UnityEngine;

namespace Granjita.Classes.Enemies {
    [CreateAssetMenu(fileName = "Enemy", menuName = "Game/Enemy")]
    public class Enemy : ScriptableObject {
        public string Name;
        public Stats EnemyStats;
        public int EnemyLevel;
    }
}
