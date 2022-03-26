using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{
    [RequireComponent(typeof(Rigidbody))]
    public class Hero_Jump : MonoBehaviour
    {
        [SerializeField] private float jumpStrength = 10f; //создали переменную отвечающую за силу прыжка
        [SerializeField] private float maxGroundDistance = 0.3f; //создали переменную отвечающую за максимальную дистанцию до поверхности
        private Rigidbody _rigidbody; //создали переменную для ссылки на компонент ригитбоди
        private Transform _groundCheckObject; //создали переменную для ссылки на точку граундчек

        private bool isGrounded; //переменная чтобы разблокировать возможность для прыжка

        void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>(); //инициализируем компонент ригитбоди
            _groundCheckObject = GameObject.FindGameObjectWithTag("GroundCheck").transform; //ищем и сохраняем точку граундчек
        }
        void Start()
        {

        }

        void Update()
        {
            isGrounded = Physics.Raycast(_groundCheckObject.transform.position, Vector3.down, maxGroundDistance);
            //Raycast - это некоторый луч, испускаемый из некоторого объекта в некотором направлении некоторой длины(либо бесконечный)
            //для определения коллизий(столкновений) с объектами. Принимает 3 параметра: 1 - начальная точка луча в мировых координатах,
            //2 - направление луча и 3 - максимальное расстояние на котором луч должен проверять наличие коллизий.

            if (Input.GetButtonDown("Jump") && isGrounded) //проверяем если нажата кнопка прыжка и одновременно игрок стоит на земле
            {
                _rigidbody.AddForce(Vector3.up * 100 * jumpStrength);
            // AddForce - этот метод используется для придания импульса физическому объекту методом толчка.
            }
        }
    }
}
