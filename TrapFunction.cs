using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class TrapFunction : MonoBehaviour
{
    public string sceneName = "Level_1"; // Объявляет имя сцены, а именно точку возврата.

    void OnTriggerEnter(Collider other) // При коллизии -
    {
        EditorSceneManager.LoadScene(sceneName); // Отправляет игрока в другую сцену.
    }
}
