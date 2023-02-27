using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDemageable
{
    [SerializeField] private int health;
    public int Health 
    {
        get { return health; }
        set 
        {
            health = value;
            if (health <= 0)
            {
                health = 0;
                Die();
            }
        }
    }

    public virtual void TakeDamage(int damageValue)
    {
        Health -= damageValue;
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
    
    private void Awake()
    {
        tag = "Enemy";
    }
}
