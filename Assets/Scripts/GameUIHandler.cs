using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUIHandler : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    private GameManager gameManager;
    private float m_Highscore;
    public string topPlayerName;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        if (GameManager.Instance != null)
        {
            topPlayerName = GameManager.Instance.topPlayerName;
            m_Highscore = GameManager.Instance.highScore;
            highScoreText.text = "Best Score: " + GameManager.Instance.topPlayerName + " : " + m_Highscore;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int scoreToAdd)
    {
        gameManager.score += scoreToAdd;
        scoreText.text = "Score: " + gameManager.score;
       
        if(gameManager.score > m_Highscore)
        {
           
            SetHighScore(gameManager.score);
        }
    }

    public void GameOver()
    {
        gameManager.isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

        if (gameManager.score > m_Highscore)
        {
            gameManager.highScore = gameManager.score;
            gameManager.topPlayerName = gameManager.playerName;
            gameManager.SavePlayerData();
        }

    }

    public void RestartGame()
    {
        gameManager.isGameActive = true;
        SceneManager.LoadScene(0);
    }

    void SetHighScore(float highscore)
    {

        highScoreText.text = "Best Score :" + gameManager.topPlayerName + " : " + highscore;

    }
}
