using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{
    public class Shooting : MonoBehaviour
    {
        [SerializeField] private GameObject bulletsPrefab;
        [SerializeField] private Transform spawnPoint1;
        [SerializeField] private Transform spawnPoint2;
        [SerializeField] private Transform spawnPoint3;
        [SerializeField] private Transform spawnPoint4;

        private float step = 10f;
        private float nextShoot;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Shoot();
            }
        }
      
        private void Shoot()
        {
            var bullet1 = Instantiate(bulletsPrefab, spawnPoint1.position, spawnPoint1.rotation);
            var bullet2 = Instantiate(bulletsPrefab, spawnPoint2.position, spawnPoint2.rotation);
            var bullet3 = Instantiate(bulletsPrefab, spawnPoint3.position, spawnPoint3.rotation);
            var bullet4 = Instantiate(bulletsPrefab, spawnPoint4.position, spawnPoint4.rotation);
            if (!(Time.time > nextShoot))
            {
                return;
            }
            else nextShoot = Time.time + step;
        }
    }
}
