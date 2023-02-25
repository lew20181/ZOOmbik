using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    [SerializeField] private float offset;

    private Rigidbody2D _rigidbody2D;
    private Camera _camera;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _camera = Camera.main;
    }

    private void Update()
    {
        var cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        var rotation = Mathf.Atan2(cursorPosition.y, cursorPosition.x) * Mathf.Rad2Deg;
        
        _rigidbody2D.MoveRotation(rotation + offset);
    }
}
