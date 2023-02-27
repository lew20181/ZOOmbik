using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombik : Enemy
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            TakeDamage(10);
        }
    }
}
