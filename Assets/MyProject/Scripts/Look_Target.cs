using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{
    public class Look_Target : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float rotationSpeed = 0.5f;
      
        private void FixedUpdate()
        {
            var direction = target.position - transform.position;
            var step = Vector3.RotateTowards(transform.forward, direction, rotationSpeed * Time.fixedDeltaTime, 0f);
            transform.rotation = Quaternion.LookRotation(step);
            // Quaternion -  ватернион представл€ет собой вращение на определенный угол вокруг произвольной оси.
            // Ћюбое вращение в Ёйлеровом пространстве можно задать с помощью кватерниона

            //LookRotation - ‘ункци€ LookRotation (или SetLookRotation) создает вращение, при котором ось Z сонаправленна forward,
            //а ось Y сонаправленна upwards. Quaternion.LookRotation(Vector3 forward, Vector3 upwards = Vector3.up);
        }
    }
}
