using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{
    public class Door_Open : MonoBehaviour
    {
        private MeshRenderer door_color;
        private Vector3 first_position;

        private void OnTriggerEnter(Collider dr)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
            transform.position = new Vector3(5f, 2.5f, 6.8f);
            if (transform.position != first_position)
            {
                Destroy(GameObject.FindGameObjectWithTag("Mechanism"), 1f);
            }
        }
    }
}
