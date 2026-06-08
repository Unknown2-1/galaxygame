using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float smoothTime = 0.08f;
    public float tiltAmount = 20f;

    private Rigidbody2D rb;
    private Vector2 input;
    private Vector2 currentVelocity;
    private Vector2 smoothVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        input = input.normalized;

        float targetTilt = -input.x * tiltAmount;
        Quaternion targetRotation = Quaternion.Euler(0, 0, targetTilt);

        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            targetRotation,
            Time.deltaTime * 8f
        );
    }

    void FixedUpdate()
    {
        Vector2 targetVelocity = input * speed;

        currentVelocity = Vector2.SmoothDamp(
            currentVelocity,
            targetVelocity,
            ref smoothVelocity,
            smoothTime
        );

        rb.linearVelocity = currentVelocity;
    }
}