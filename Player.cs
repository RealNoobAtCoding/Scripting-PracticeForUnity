using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private int health = 10;
    public GameObject Gun;
    public Transform muzzle;
    public GameObject Bullet;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока:" + health);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, muzzle.position, muzzle.rotation);
        }
    }
}
