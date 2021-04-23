using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetScore : MonoBehaviour
{
    public Text rescore;
    
    // Start is called before the first frame update
    void Start()
    {
        rescore.text = HighScore.instance.score.ToString();
        
        
    }

}
