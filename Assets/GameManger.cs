using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public GameObject gameOverCanvas;

    private void Start()
    {
        // Setting the timescale to 1 which makes the computer run at normal speed
        Time.timeScale = 1;

    }
    public void GameOver()
    {
        // When the game is over, show the game over canvas and set the timescale to 0 which makes the game stop
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;

    }

    public void Replay()
    {
        // Reload the game again
        SceneManager.LoadScene(0);
    }
    
}
