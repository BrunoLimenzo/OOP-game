using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private void OnEnable()
    {
        EventManager.gameOver += GameOver;
    }

    private void OnDisable()
    {
        EventManager.gameOver -= GameOver;
    }
    void GameOver()
    {
        Time.timeScale = 0f;
        Debug.Log("Game Over");
    }
}
