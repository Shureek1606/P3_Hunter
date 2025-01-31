using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    public Vector3 startPosition; // Начальная позиция
    public Vector3 endPosition;   // Конечная позиция
    public float speed = 2.0f;    // Скорость движения

    private bool movingToEnd = true; // Флаг для определения направления движения

    void Start()
    {
        // Инициализация начальной позиции
        startPosition = transform.position;
    }

    void Update()
    {
        // Определяем текущую целевую позицию
        Vector3 targetPosition = movingToEnd ? endPosition : startPosition;

        // Двигаем объект к целевой позиции
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Проверяем, достиг ли объект целевой позиции
        if (transform.position == targetPosition)
        {
            // Меняем направление движения
            movingToEnd = !movingToEnd;
        }
    }
}
