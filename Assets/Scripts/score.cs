
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{

    public Transform player;
    public Text ScoreText;
    public string a;
    
    
  
   void Update()
   {
       ScoreText.text = player.position.z.ToString("0");
     
   }

   public string SetScore()
   {
       a = player.position.z.ToString("0");
       return a;
   }  
        
        
   }

    
      
    

  


