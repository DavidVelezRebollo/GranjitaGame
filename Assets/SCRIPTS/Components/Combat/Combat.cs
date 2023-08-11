using Granjita.Components.Characters;
using Granjita.Components.Enemies;
using Granjita.Interfaces;

using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;

namespace Granjita.Components.Combat {
    public class Combat : MonoBehaviour {
        [SerializeField] private List<CharacterComponent> CombatingCharacters;
        [SerializeField] private List<EnemyComponent> CombatingEnemies;
        [Space(10)]
        [Header("Buttons")]
        [SerializeField] private Button AttackButton;
        [SerializeField] private Button AbilitiesButton;
        [SerializeField] private Button ItemButton;


        private List<ICombatable> _combatTurns = new List<ICombatable>();

        private int _currentTurn = 0;
        private bool _isEnemyTurn;

        private void Start() {
            InitializeButtons();
            InitializeCombat();
        }

        private void Update() {
            _isEnemyTurn = _combatTurns[_currentTurn].GetType() == typeof(EnemyComponent);

            if (!_isEnemyTurn) return;

            Debug.Log($"Turno del enemigo");
            _currentTurn = (_currentTurn + 1) % _combatTurns.Count;
        }

        private void InitializeButtons() {
            AttackButton.onClick.AddListener(OnAttackButton);
            ItemButton.onClick.AddListener(OnItemButton);
            AbilitiesButton.onClick.AddListener(OnAbilitiesButton);
        }

        private void InitializeCombat() {
            foreach(ICombatable character in CombatingCharacters) {
                _combatTurns.Add(character);
            }

            foreach(ICombatable enemy in CombatingEnemies) {
                _combatTurns.Add(enemy);
            }

            _combatTurns = _combatTurns.OrderByDescending(x => x.GetSpeed()).ToList();
        }

        private void OnAttackButton() {
            if(_isEnemyTurn) return;

            Debug.Log($"{_combatTurns[_currentTurn]} attacked");
            _currentTurn = (_currentTurn + 1) % _combatTurns.Count;
        }

        private void OnItemButton() {
            if(_isEnemyTurn) return;

            Debug.Log($"{_combatTurns[_currentTurn]} uses an item");
            _currentTurn = (_currentTurn + 1) % _combatTurns.Count;
        }

        private void OnAbilitiesButton() {
            if(_isEnemyTurn) return;

            Debug.Log($"{_combatTurns[_currentTurn]} uses an abilitie");
            _currentTurn = (_currentTurn + 1) % _combatTurns.Count;
        }
    }
}
