using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnPause : MonoBehaviour
{
    // Start is called before the first frame update

private bool muted = false;
    void Start()
    {
       if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted",0);
            Load();
        }
        else
        {
            Load();
        }
        AudioListener.pause = muted; 
    }

    
    public void OnButtonPress()
    {
        if(muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }

        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        Save();
     }

     private void Load()
     {
         muted = PlayerPrefs.GetInt("muted") == 1;
     }

     private void Save()
     {
         PlayerPrefs.SetInt("muted", muted ? 1 : 0);
     }

}
