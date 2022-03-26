using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{
    [RequireComponent(typeof(Rigidbody))]
    public class Hero_Jump : MonoBehaviour
    {
        [SerializeField] private float jumpStrength = 10f; //������� ���������� ���������� �� ���� ������
        [SerializeField] private float maxGroundDistance = 0.3f; //������� ���������� ���������� �� ������������ ��������� �� �����������
        private Rigidbody _rigidbody; //������� ���������� ��� ������ �� ��������� ���������
        private Transform _groundCheckObject; //������� ���������� ��� ������ �� ����� ���������

        private bool isGrounded; //���������� ����� �������������� ����������� ��� ������

        void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>(); //�������������� ��������� ���������
            _groundCheckObject = GameObject.FindGameObjectWithTag("GroundCheck").transform; //���� � ��������� ����� ���������
        }
        void Start()
        {

        }

        void Update()
        {
            isGrounded = Physics.Raycast(_groundCheckObject.transform.position, Vector3.down, maxGroundDistance);
            //Raycast - ��� ��������� ���, ����������� �� ���������� ������� � ��������� ����������� ��������� �����(���� �����������)
            //��� ����������� ��������(������������) � ���������. ��������� 3 ���������: 1 - ��������� ����� ���� � ������� �����������,
            //2 - ����������� ���� � 3 - ������������ ���������� �� ������� ��� ������ ��������� ������� ��������.

            if (Input.GetButtonDown("Jump") && isGrounded) //��������� ���� ������ ������ ������ � ������������ ����� ����� �� �����
            {
                _rigidbody.AddForce(Vector3.up * 100 * jumpStrength);
            // AddForce - ���� ����� ������������ ��� �������� �������� ����������� ������� ������� ������.
            }
        }
    }
}
