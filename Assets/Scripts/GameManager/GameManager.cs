
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded;
    float restartDelay = 1f;
    public static int deaths;
    public static int jumpCounts = 0;
    public static int maxJumps = 1;
    public static bool gameCanStart;
   public void EndGame() {

        gameHasEnded = false;
        if(gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);      
        }
    }

    void Restart() {
        deaths += 1;
        gameCanStart = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
