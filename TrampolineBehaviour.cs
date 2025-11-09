using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineBehaviour : MonoBehaviour
{
    public float jumpAmplifier = 2.5f; // Объявление переменной с плавающей запятой (чтобы при вводе десятичной дроби скрипт не выдавал ошибку).

    void OnTriggerEnter(Collider other) // Алгоритм выполняется когда метод замечает столкновение.
    {
        other.GetComponent<Jump>().jumpStrength *= jumpAmplifier; // Меняет силу прыжка на произведение силы и jumpAmplifier.
    }

    void OnTriggerExit(Collider other) // Алгоритм выполняется когда метод замечает выход из коллайдера.
    {
        other.GetComponent<Jump>().jumpStrength /= jumpAmplifier; // Меняет силу прыжка на прежнюю.
    }
}
