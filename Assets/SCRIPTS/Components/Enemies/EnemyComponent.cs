using Granjita.Classes.Enemies;
using Granjita.Shared;
using Granjita.Interfaces;

using UnityEngine;

namespace Granjita.Components.Enemies {
    public class EnemyComponent : MonoBehaviour, ICombatable {
        [SerializeField] private Enemy EnemyInfo;

        public float GetSpeed() {
            return EnemyInfo.EnemyStats.GetSpeed();
        }
    }
}
