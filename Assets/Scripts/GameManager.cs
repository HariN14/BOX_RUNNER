
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int Ret;
    bool gameHasEnded = false;

    public float restartDelay = 5f;

    public GameObject CompleteLevelUi;
    
    public void CompleteLevel ()
    {
        CompleteLevelUi.SetActive(true);

    }


    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            SceneManager.LoadScene("Restart_Screen");
            Invoke("Restart_Screen", restartDelay);
        }
        
    }
    
    public void Restart_Screen()
    {
        SceneManager.LoadScene("Restart_Screen");
    }
    public void Restart ()
    {
        Ret = PlayerPrefs.GetInt("SavedScene");
        SceneManager.LoadScene(Ret);
        HighScore.instance.ResetScore();
    }


}
