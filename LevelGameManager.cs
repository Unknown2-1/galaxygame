using UnityEngine;

public class LevelGameManager : MonoBehaviour
{
    public static LevelGameManager instance;

    public int totalStars;
    public int collectedStars;

    private void Awake()
    {
        instance = this;

        totalStars = GameObject.FindGameObjectsWithTag("Star").Length;
        collectedStars = 0;

        Debug.Log("Total bintang: " + totalStars);
    }

    public void AddStar()
    {
        collectedStars++;
        Debug.Log("Bintang: " + collectedStars + "/" + totalStars);
    }

    public bool AllStarsCollected()
    {
        return collectedStars >= totalStars;
    }
}