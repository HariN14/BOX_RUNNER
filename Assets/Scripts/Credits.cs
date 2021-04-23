
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void StartGame()
  {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - SceneManager.GetActiveScene().buildIndex );
  }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
