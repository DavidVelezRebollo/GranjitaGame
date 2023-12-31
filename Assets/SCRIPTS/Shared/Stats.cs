using UnityEngine;

namespace Granjita.Shared {
    [System.Serializable]
    public class Stats {
        [SerializeField] private float Health;
        [SerializeField] private float Attack;
        [SerializeField] private float Defense;
        [SerializeField] private float Evasion;
        [SerializeField] private float Magic;
        [SerializeField] private float Speed;

        public Stats(float health, float attack, float defense, float evasion, float magic, float speed) {
            Health = health;
            Attack = attack;
            Defense = defense;
            Evasion = evasion;
            Magic = magic;
            Speed = speed;
        }

        public float GetHealth() {
            return Health;
        }
        
        public float GetAttack() {
            return Attack;
        }
        
        public float GetDefense() {
            return Defense;
        }
        
        public float GetEvasion() {
            return Evasion;
        }
        
        public float GetMagic() {
            return Magic;
        }
        
        public float GetSpeed() {
            return Speed;
        }
    }
}
