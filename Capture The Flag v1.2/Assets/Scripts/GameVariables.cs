using UnityEngine.SceneManagement;

public static class GameVariables
{
    public static bool twoPlayers = false;
    public static int blueScore = 0;
    public static int redScore = 0;
    public static int gameNum = 3;
    public static int currentGame;


    public static void Restart()
    {

        SceneManager.LoadScene(4);

    }
}
