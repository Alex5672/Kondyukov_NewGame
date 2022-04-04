using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{

    public class Health : MonoBehaviour
    {
        [SerializeField] private float maxHealth = 100f;
        [SerializeField] private float curHealth;
        
        void Awake()
        {
            curHealth = maxHealth;   
        }

        public void Hit(float damage)
        {
            curHealth -= damage;
            if (curHealth <= 0)
            {
                Die();
            }
        }

        public void Recovery(float heal)
        {
            if (curHealth < 100)
            {
                curHealth += heal;
            }
            else { return; }
        }

        private void Die()
        {
            gameObject.SetActive(false);
        }
    }
}
