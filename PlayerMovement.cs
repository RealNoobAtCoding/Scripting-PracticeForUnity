using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1.5f; // Скорость передвижения.
    public int level = 1; // Уровень, используемое как слагаемое.
    public int health = 10; // Здоровье, также используемое как слагаемое и как значение для печати в консоль.
    // Start is called before the first frame update
    void Start()
    {
        health = health + level; // Функция присваивания суммы Level и Health к Health.
        print("Health:" + health); // Сама печать Health в консоль.
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position; // Получение позиции в объекте, к которой принадлежит скрипт.
        newPosition.z += speed * Time.deltaTime; // Высчитывание позиции каждый промежуток времени (Разности времён) с использовании speed.
        transform.position = newPosition; // Присваивание позиции и перемещение объекта.
    }
}
