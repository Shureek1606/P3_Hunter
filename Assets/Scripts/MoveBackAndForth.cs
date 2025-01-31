using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    public Vector3 startPosition; // ��������� �������
    public Vector3 endPosition;   // �������� �������
    public float speed = 2.0f;    // �������� ��������

    private bool movingToEnd = true; // ���� ��� ����������� ����������� ��������

    void Start()
    {
        // ������������� ��������� �������
        startPosition = transform.position;
    }

    void Update()
    {
        // ���������� ������� ������� �������
        Vector3 targetPosition = movingToEnd ? endPosition : startPosition;

        // ������� ������ � ������� �������
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // ���������, ������ �� ������ ������� �������
        if (transform.position == targetPosition)
        {
            // ������ ����������� ��������
            movingToEnd = !movingToEnd;
        }
    }
}
