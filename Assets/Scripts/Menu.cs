
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

  
  public void StartGame()
  {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
public void Option()
  {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
  }

public void Back()
  {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - SceneManager.GetActiveScene().buildIndex);
  }  
  public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

public void Level_Select()
{
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
}
public void Level1_Select()
{
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
}

public void Level2_Select()
{
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
}
public void Level3_Select()
{
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
}
public void Level4_Select()
{
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
}

public void Endless_Select()
{
  SceneManager.LoadScene("Level 5");
}
}
