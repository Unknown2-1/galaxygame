using UnityEngine;

public class StarCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LevelGameManager.instance.AddStar();
            Destroy(gameObject);
        }
    }
}   