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
            // Quaternion - ���������� ������������ ����� �������� �� ������������ ���� ������ ������������ ���.
            // ����� �������� � ��������� ������������ ����� ������ � ������� �����������

            //LookRotation - ������� LookRotation (��� SetLookRotation) ������� ��������, ��� ������� ��� Z ������������� forward,
            //� ��� Y ������������� upwards. Quaternion.LookRotation(Vector3 forward, Vector3 upwards = Vector3.up);
        }
    }
}
