using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{

    public class Bomd_Explosion : MonoBehaviour
    {
        [SerializeField] private GameObject Effect;
       
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Effect.SetActive(true);
                Destroy(gameObject, 3f);
                Destroy(GameObject.Find("Hero"), 3f);
            }
        }
        private void Start()
        {
            GameObject.Find("Bomb_Effect").SetActive(false);
        }
    }
}
