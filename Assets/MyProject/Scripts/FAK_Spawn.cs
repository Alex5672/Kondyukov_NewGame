using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{

    public class FAK_Spawn : MonoBehaviour
    {
        [SerializeField] private Transform spawnPosition;
        [SerializeField] private GameObject fak_Prefab;

        void Awake()
        {
            var enemy = Instantiate(fak_Prefab, spawnPosition.position, spawnPosition.rotation);
        }
    } 
}




    