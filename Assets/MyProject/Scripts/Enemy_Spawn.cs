using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{

    public class Enemy_Spawn : MonoBehaviour
    {
        [SerializeField] private Transform spawnPosition;
        [SerializeField] private GameObject enemyPrefab;

        /*[SerializeField] private GameObject enemyPrefab;
        private Vector3 enemyPosition = new Vector3(0f, 1f, 20f);*/
        void Start()
        {
            Instantiate(enemyPrefab, spawnPosition.position, spawnPosition.rotation);
            /*var enemy = Instantiate(enemyPrefab, transform);
            enemy.transform.localPosition = enemyPosition;*/
        }

        void Update()
        {

        }
    }
}
