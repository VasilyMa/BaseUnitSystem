using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleEnemy : Enemy
{
    [SerializeField] private Transform target;
    [SerializeField] private float health;
    private void Update()
    {
        Move();
    }
    public override void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, 2 * Time.deltaTime);
    }
    public override void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= 0) Die();
    }
    public override void Die()
    {
        Destroy(gameObject);
    }
}
