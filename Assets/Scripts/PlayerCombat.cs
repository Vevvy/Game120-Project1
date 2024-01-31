using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerStuff
{
    public class PlayerCombat : MonoBehaviour
    {
        // Declare vars
        [SerializeField, Range(10, 1000)] private float maxHealth = 100;
        [SerializeField] private float health;
        [SerializeField, Range(10, 1000)] private float maxMana = 100;
        [SerializeField] private float mana;

        [SerializeField, Range(5, 300)] private int attackCooldown1 = 30;
        private int aC1;
 
        // Public fields
        public float GetHeatlh { get; }
        public float GetMana { get; }

        // Bools
        [SerializeField] private bool attacking = false;

        void Start()
        {
            health = maxHealth;
            mana = maxMana;
        }

        void Update()
        {
           if(Input.GetMouseButton(0) && aC1 == attackCooldown1 && attacking == false)
            {
                aC1 = 0;
                Attack();
            }
        }

        void FixedUpdate()
        {
            if(aC1 < attackCooldown1) aC1 += 1;
        }

        void Attack()
        {
            attacking = true;

            // create fireball

            attacking = false;
        }
    }
}

