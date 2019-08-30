//UNİO GAMES 2019
using System.Collections;
using System.Collections.Generic;
using CloudOnce;
using UnityEngine;
using UnityEngine.UI;
public class    ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        Cloud.Initialize(false, true);  
    }


    public void CloudOnceInitializeComplete()
    {
        Cloud.OnInitializeComplete -= CloudOnceInitializeComplete;
        Debug.LogWarning("Initialized");
    }


    public void Clickscore()
    {

        score += 1;
        scoreText.text = score.ToString();
        Leaderboards.HighScore.SubmitScore(score);
    }
   
}
//UNİO GAMES 2019
