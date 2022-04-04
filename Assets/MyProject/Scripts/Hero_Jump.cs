using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kondyukov_NewGame
{
    [RequireComponent(typeof(Rigidbody))]
    public class Hero_Jump : MonoBehaviour
    {
        [SerializeField] private float jumStrength = 2f; //������� ���������� ���������� �� ���� ������
        private Rigidbody m_rigidbody; //������� ���������� ��� ������ �� ��������� ���������
        private bool isAir; //���������� ����� �������������� ����������� ��� ������

        private void Start()
        {
            m_rigidbody = GetComponent<Rigidbody>(); //�������������� ��������� ���������
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Space) && !isAir)
            {
                isAir = true;
                m_rigidbody.AddForce(Vector3.up * 100 * jumStrength);
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
            {
                isAir = false;
            }
        }
    }
}
