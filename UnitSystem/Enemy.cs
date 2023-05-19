using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IUnit, IMovable, IDamagable
{
    public virtual void Die()
    {

    }

    public virtual void Move()
    {

    }

    public virtual void TakeDamage(float damage)
    {

    }
}
