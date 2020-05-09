using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager1 : MonoBehaviour
{
    bool gameHasEnded = false;
    public float delayRestart= 1f;
    // Start is called before the first frame update
    public void EndGame()
    {
        if(!gameHasEnded){
            Debug.Log("GAME OVER");
            gameHasEnded = true;
            Invoke("Restart", delayRestart);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
