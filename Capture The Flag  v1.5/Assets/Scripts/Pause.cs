using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameVariables;

public class Pause : MonoBehaviour
{

    public GameObject pauseMenu;
    public Animator pauseAnim;

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if (pause == false)
            {
                pauseMenu.SetActive(true);

                pause = true;
            }
            else
            {
                pauseMenu.SetActive(false);

                pause = false;
            }
                Debug.Log(pause);
        }
    }
    
}
