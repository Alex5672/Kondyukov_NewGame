using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{

    public class Hero_Bird : MonoBehaviour
    {
        [SerializeField] private GameObject birdPrefab; //добавили ссылку на префаб проекта
        private Vector3 birdPosition = new Vector3(-2f, 2f, 0.5f); //задаем переменную с определенными векторами
        void Start()
        {
           
        }
        void Update()
        {
            if (Input.GetMouseButtonUp(0))
            {
                CallBird();
            }
        }
        private void CallBird()
        {
            var bird = Instantiate(birdPrefab, transform); //создали переменную для инстаншиирования префаба бёрд на сцене
            bird.transform.localPosition = birdPosition; //определяем для префаба трансформ позицию

            if (bird) //если бёрд тру, то через 2 сек удаляем
            {
                Destroy(bird.gameObject, 2);
            }
        }
    }
}
