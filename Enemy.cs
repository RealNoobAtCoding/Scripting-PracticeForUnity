using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int damage = 2;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }
    public void OnTriggerEnter(Collider other)
    {
        HealthSystem player = other.GetComponent<HealthSystem>();
        player.TakeDamage(damage);
        Task.Delay(10000);
    }
}
