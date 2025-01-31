using UnityEngine;

public class RotateToCursor : MonoBehaviour
{
    public Camera mainCamera; // Ссылка на основную камеру
    public LayerMask groundLayer; // Слой, на который будет проецироваться луч

    void Update()
    {
        // Получаем позицию курсора на экране
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        // Проецируем луч из камеры в точку курсора
        Ray ray = mainCamera.ScreenPointToRay(screenPosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayer))
        {
            // Получаем позицию точки попадания луча
            Vector3 targetPosition = hit.point;

            // Вычисляем направление от объекта к точке попадания
            Vector3 direction = targetPosition - transform.position;
            

            // Поворачиваем объект в сторону курсора
            if (direction != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(direction);
            }
        }
    }
}
