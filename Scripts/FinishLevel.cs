using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public string nextLevelName = "Level2";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (LevelGameManager.instance.AllStarsCollected())
            {
                SceneManager.LoadScene(nextLevelName);
            }
            else
            {
                Debug.Log("Ambil semua bintang dulu!");
            }
        }
    }
}