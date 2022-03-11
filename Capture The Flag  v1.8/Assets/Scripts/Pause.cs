﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static GameVariables;

public class Pause : MonoBehaviour
{

    public GameObject pauseMenu;


    void Update()
    {
        if (Input.GetKeyDown("p") || Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause == false)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
                Debug.Log(pause);
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void StartOver()
    {
        Time.timeScale = 1f;
        pause = false;
        SceneManager.LoadScene(0);

    }

    public void ChangeVolume()
    {
        if (audioVolume < 2)
        {
            audioVolume += 1;
        }
        else if (audioVolume == 2)
        {
            audioVolume = 0;
        }

    }
}
