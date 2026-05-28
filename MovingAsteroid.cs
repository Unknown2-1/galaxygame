using UnityEngine;

public class MovingAsteroid : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 2f;
    public bool moveHorizontal = true;

    private Vector3 startPosition;
    private float randomOffset;

    void Start()
    {
        startPosition = transform.position;

        // Biar tiap asteroid mulai dari posisi gerak yang beda
        randomOffset = Random.Range(0f, 10f);
    }

    void Update()
    {
        float movement = Mathf.Sin((Time.time + randomOffset) * speed) * distance;

        if (moveHorizontal)
        {
            transform.position = startPosition + new Vector3(movement, 0f, 0f);
        }
        else
        {
            transform.position = startPosition + new Vector3(0f, movement, 0f);
        }
    }
}