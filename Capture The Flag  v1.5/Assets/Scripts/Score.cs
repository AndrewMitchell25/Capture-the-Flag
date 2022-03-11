using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GameVariables;

public class Score : MonoBehaviour
{
    public Text redScoreText;
    public Text blueScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        redScoreText.text = "RED TEAM : " + redScore;
        blueScoreText.text = "BLUE TEAM : " + blueScore;
    }
}
