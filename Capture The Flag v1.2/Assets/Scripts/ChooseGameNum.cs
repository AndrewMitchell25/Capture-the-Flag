﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameVariables;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseGameNum : MonoBehaviour
{
    public Text writtenNum;

    void Update()
    {
        writtenNum.text = gameNum.ToString();
    }

    public void IncreaseGameNum()
    {
        gameNum += 1;
        Debug.Log(gameNum);

    }

    public void DecreaseGameNum()
    {
        if (gameNum > 1)
        {
            gameNum -= 1;
            Debug.Log(gameNum);
        }


    }

    public void StartGame()
    {
        if (twoPlayers == true)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(3);

        }
    }
}
