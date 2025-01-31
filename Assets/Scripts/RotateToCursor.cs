using UnityEngine;

public class RotateToCursor : MonoBehaviour
{
    public Camera mainCamera; // ������ �� �������� ������
    public LayerMask groundLayer; // ����, �� ������� ����� �������������� ���

    void Update()
    {
        // �������� ������� ������� �� ������
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        // ���������� ��� �� ������ � ����� �������
        Ray ray = mainCamera.ScreenPointToRay(screenPosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayer))
        {
            // �������� ������� ����� ��������� ����
            Vector3 targetPosition = hit.point;

            // ��������� ����������� �� ������� � ����� ���������
            Vector3 direction = targetPosition - transform.position;
            

            // ������������ ������ � ������� �������
            if (direction != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(direction);
            }
        }
    }
}
