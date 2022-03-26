using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{
    public class Hero_Movement : MonoBehaviour
    {
        [SerializeField] private float speed = 5f; //���������� ��� �������� ��������
        [SerializeField] private float speedRun = 10f; //���������� ��� �������� ����
        [SerializeField] private Vector3 direction; //���������� ��� ����������� ��������

        private bool isRunning;

        [SerializeField] private string run = "Run"; //���������� ��� ����
        [SerializeField] private string horizontal = "Horizontal"; //���������� ��� �������� �� �����������
        [SerializeField] private string vertical = "Vertical"; //���������� ��� �������� �� ���������

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
            transform.position += direction * (isRunning ? speedRun : speed) * Time.fixedDeltaTime; //���������� ��� �������� ������� ����������� ��� ����� ���� ����������
        }
    }
}
