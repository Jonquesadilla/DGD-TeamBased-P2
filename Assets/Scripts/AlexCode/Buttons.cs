using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Buttons : MonoBehaviour
{
    
    public TMP_Text FinalScore;
    public int HighScore = 0;
    
    public void GameButton()
    {

        SceneManager.LoadScene("Alex");

    }
    
    public void MMButton()
    {

        SceneManager.LoadScene("Start");

    }

    void Start()
    {

        

    }

    void Update()
    {

        // if (HighScore < JoshCode.Score)
        // {
        //     
        //     FinalScore.text = "Congratulations!\nYour Highscore is now:\n" + JoshCode.Score + "!";
        //     HighScore = JoshCode.Score;
        //
        // }
        
        
            
            FinalScore.text = "Game Over!\nYour final score was:\n" + JoshCode.Score;
            
        

    }

}
