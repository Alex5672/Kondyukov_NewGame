using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{

    public class Hero_Bird : MonoBehaviour
    {
        [SerializeField] private GameObject birdPrefab; //�������� ������ �� ������ �������
        private Vector3 birdPosition = new Vector3(-2f, 2f, 0.5f); //������ ���������� � ������������� ���������
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
            var bird = Instantiate(birdPrefab, transform); //������� ���������� ��� ���������������� ������� ��� �� �����
            bird.transform.localPosition = birdPosition; //���������� ��� ������� ��������� �������

            if (bird) //���� ��� ���, �� ����� 2 ��� �������
            {
                Destroy(bird.gameObject, 2);
            }
        }
    }
}
