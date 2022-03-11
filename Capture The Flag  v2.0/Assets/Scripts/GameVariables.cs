using UnityEngine.SceneManagement;
using UnityEngine;

public static class GameVariables
{
    public static bool twoPlayers = false;
    public static int blueScore = 0;
    public static int redScore = 0;
    public static int gameNum = 3;
    public static int currentGame;
    public static bool pause;
    public static bool lastScorerRed;
    public static int audioVolume = 2;
    public static int playerSpeed = 10;


    public static void Captured()
    {

        SceneManager.LoadScene(4);

    }
}
