using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{
    public class Hero_Movement : MonoBehaviour
    {
        [SerializeField] private float speed = 5f; //переменная для скорости движения
        [SerializeField] private float speedRun = 10f; //переменная для скорости бега
        [SerializeField] private Vector3 direction; //переменная для направления движения

        private bool isRunning;

        [SerializeField] private string run = "Run"; //переменная для бега
        [SerializeField] private string horizontal = "Horizontal"; //переменная для движения по горизонтали
        [SerializeField] private string vertical = "Vertical"; //переменная для двтжения по вертикали

        void Start()
        {
       
        }
        void Update()
        {
            direction.x = Input.GetAxis(horizontal);
            direction.z = Input.GetAxis(vertical);
            isRunning = Input.GetButton(run);
        }
        private void FixedUpdate()
        {
            transform.position += direction * (isRunning ? speedRun : speed) * Time.fixedDeltaTime; //переменная для движения которая формируется при сумме всех переменных
        }
    }
}
