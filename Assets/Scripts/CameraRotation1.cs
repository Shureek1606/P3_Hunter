using UnityEngine;

public class CameraRotation1 : MonoBehaviour
{
    public GameObject gun; // Объект пистолета
    public float mouseSensitivity = 100f; // Чувствительность мыши
    public float rotationSpeed = 50f; // Скорость поворота пистолета

    private float verticalRotation = 0;
    private float upDownRange = 180f; // Ограничение по вертикали

    void Start()
    {
        // Заблокировать курсор в центре экрана
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Получение ввода с мыши
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Вращение пистолета
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);

        // Применение вращения
        transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
        gun.transform.localRotation = Quaternion.Euler(0, mouseX, 0);

    }
}
