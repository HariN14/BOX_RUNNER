using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static HighScore instance;

    public int score, highscore;

    public Text scText, hsText, goText;

    private void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score++;

        UpdateHighScore();

        scText.text = score.ToString();
        goText.text = score.ToString();
    }

    public void UpdateHighScore()
    {
        if(score > highscore)
        {
            highscore = score;
            hsText.text = highscore.ToString();
        }
    }

    public void ResetScore()
    {
        score = 0;
    }
}
