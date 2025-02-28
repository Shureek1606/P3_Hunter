using UnityEngine;

public class CameraRotation1 : MonoBehaviour
{
    public GameObject gun; // ������ ���������
    public float mouseSensitivity = 100f; // ���������������� ����
    public float rotationSpeed = 50f; // �������� �������� ���������

    private float verticalRotation = 0;
    private float upDownRange = 180f; // ����������� �� ���������

    void Start()
    {
        // ������������� ������ � ������ ������
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // ��������� ����� � ����
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // �������� ���������
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);

        // ���������� ��������
        transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
        gun.transform.localRotation = Quaternion.Euler(0, mouseX, 0);

    }
}
