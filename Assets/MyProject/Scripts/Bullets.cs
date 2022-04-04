using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{

    public class Bullets : MonoBehaviour
    {
        [SerializeField] private float speedBull = 0.5f;
        private float damage = 10f;
        private void Awake()
        {
            Destroy(gameObject, 2f);
        }
        private void FixedUpdate()
        {
            transform.position += transform.forward * speedBull * Time.fixedDeltaTime; //меняем позицию в направлении вперед + скорость
        }
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.TryGetComponent(out Health health))
            {
                health.Hit(damage);
            }
        }
    }
}
