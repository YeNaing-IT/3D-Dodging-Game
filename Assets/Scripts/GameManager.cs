using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject stone;

    public float maxX;

    public Transform spawnPoint;

    int score = 0;

    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnStone", 0.5f, 1.5f); // Call function every 1.5 sec

        InvokeRepeating("UpdateScore", 3f, 2f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnStone()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range(-maxX, maxX);

        Instantiate(stone, spawnPos, Quaternion.identity);
    }

    void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
