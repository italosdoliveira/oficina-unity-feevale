using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gameStartScreen;
    public GameObject player;
    public GameObject pipeSpawn;

    public void AddScore(){
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void GameStart(){
        gameStartScreen.SetActive(false);
        player.SetActive(true);
        pipeSpawn.SetActive(true);
    }
}
