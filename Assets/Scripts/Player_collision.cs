
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_collision : MonoBehaviour
{
    public Player_movement movement;

    public int currentScene;
    
    void OnCollisionEnter(Collision collisionInfo) 
    {
        if(collisionInfo.collider.tag == "Obsticle")
        {
           currentScene = SceneManager.GetActiveScene().buildIndex;
           PlayerPrefs.SetInt("SavedScene",currentScene);
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    } 
}
