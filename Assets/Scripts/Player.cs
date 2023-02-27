using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour, IDemageable
{
    [SerializeField] private HealthBar healthbar;

    [SerializeField] private float moveSpeed;

    [SerializeField] private int maxHealth;

    private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
            if (health <= 0)
            {
                health = 0;
                Die();
            }

            healthbar.UpdateHealthbar(maxHealth, health);
        }
    }
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        Health = maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            TakeDamage(Random.Range(10, 50));
        }
    }
    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 moveDirection = new Vector2(horizontalInput, verticalInput);

        _rigidbody2D.velocity = transform.rotation * moveDirection *  moveSpeed;
    }

    private void Awake()
    {
        tag = "Player";
    }

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
