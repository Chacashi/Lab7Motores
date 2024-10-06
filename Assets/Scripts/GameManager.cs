using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void StopGame()
    {
        Time.timeScale = 0;
    }

    private void Start()
    {
        PlayGame();
    }
    public void PlayGame()
    {
        Time.timeScale = 1;
    }
}
