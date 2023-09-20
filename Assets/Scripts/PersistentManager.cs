using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class PersistentManager : MonoBehaviour
{
    // whether the player is on the title screen
    public bool onTitleScreen = true;
    public bool hasCachedTimerText = false;
    // The score. Enemies, upon death, should add to the score.
    public int totalScore = 0;

    // Individual level scores.
    public int[] levelScores = new int[3];


  
    public int livesLost = 0;


    public int levelNumber = 1;

    public CheckVariables variables;

    // TIMER DISPLAY
    public TextMeshProUGUI totalTime_Display;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void LateUpdate()
    {
        if (!onTitleScreen)
        {
            if(!hasCachedTimerText)
            {
                CacheTimeText();
            }
            float t = Time.time;
            float milliseconds = (Mathf.Floor(t * 100) % 100);
            int seconds = (int)(t % 60);
            t /= 60;
            int minutes = (int)(t % 60);
            t /= 60;
            int hours = (int)(t % 24);

            totalTime_Display.text = string.Format("<mspace=0.8em>{0}:{1}:{2}''{3}", hours.ToString("00"), minutes.ToString("00"), seconds.ToString("00"), milliseconds.ToString("00"));
        }
    }
    public int IncrementScore(int score)
    {
        totalScore += score;
        return totalScore;

    }

    public void CacheTimeText()
    {
        totalTime_Display = GameObject.Find("TotalTime_Display").GetComponent<TextMeshProUGUI>();
        hasCachedTimerText = true;
    }







}
