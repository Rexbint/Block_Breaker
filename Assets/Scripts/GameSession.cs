using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    // config params
    [Range(0.1f, 10f)] public float GameSpeed = 1f;
    public int PointsPerBlock = 83;
    public TextMeshProUGUI scoreText;
    [SerializeField] bool isAutoPlayEnabled;

    // state
    public int CurrentScore = 0;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount>1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = CurrentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = GameSpeed;
    }

    public void AddToScore()
    {
        CurrentScore += PointsPerBlock;
        scoreText.text = CurrentScore.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public bool IsAutoPlayEnabled()
    {
            return isAutoPlayEnabled;
    }
}
