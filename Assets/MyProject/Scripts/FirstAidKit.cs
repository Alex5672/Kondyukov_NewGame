using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{
    
    public class FirstAidKit : MonoBehaviour
    {
        [SerializeField] private float addHealth = 50f;

        public void OnCollisionEnter(Collision fak)
        {
            if (fak.gameObject.TryGetComponent(out Health health))
            {
                health.Recovery(addHealth);
                Destroy(gameObject, 1f);
            }

        }
    }
}
