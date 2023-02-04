using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Properties")]
    [SerializeField] float movementSpeed;

    Rigidbody2D rb;

    Vector2 moveDirection;
    Vector2 moveInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HandleInput();
    }

    void FixedUpdate()
    {
        Move();
    }

    void HandleInput()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveDirection = moveInput.normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * movementSpeed;
    }
}
