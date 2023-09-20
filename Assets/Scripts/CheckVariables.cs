using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;


public class CheckVariables : MonoBehaviour
{
    // UI GAME OBJECTS   
    TextMeshProUGUI levelDigit;
    // Total score
    TextMeshProUGUI scoreDisplay;
    // level score
    TextMeshProUGUI levelScoreDisplay;
    // number of lives lost
    TextMeshProUGUI livesLostDisplay;

    // Singleton 
    PersistentManager manager;

    // Next Scene
    public string newGameScene;

    public int currentLevelScore = 0;

    [Header("Enemy Waves")]
    public int totalSpawnWaves;
    public int currentSpawnWave;

    public int enemiesPresent = 1;
    public int scoreToClearifDie;
    public GameObject[] waves;
    bool wave2trip;


    void Awake()
    {
        wave2trip = false;
        manager = GameObject.Find("Manager").GetComponent<PersistentManager>();
        manager.hasCachedTimerText = false;
        levelDigit = GameObject.Find("LevelDigit").GetComponent<TextMeshProUGUI>();
        levelDigit.text = (manager.levelNumber.ToString());

        scoreDisplay = GameObject.Find("TotalScore_Display").GetComponent<TextMeshProUGUI>();
        scoreDisplay.text = (manager.totalScore.ToString());

        levelScoreDisplay = GameObject.Find("LevelScore_Display").GetComponent<TextMeshProUGUI>();
        levelScoreDisplay.text = (currentLevelScore.ToString());

        livesLostDisplay = GameObject.Find("LivesLostDisplay").GetComponent<TextMeshProUGUI>();
        livesLostDisplay.text = (manager.livesLost.ToString());
        manager.levelScores[scoreToClearifDie] = 0;
        if (scoreToClearifDie == 0)
        {
            manager.totalScore = 0;
        }

    }

    private void Update()
    {


        // Increment Score
        //if (Input.GetKeyDown(KeyCode.A))
        // {
        //manager.totalScore = manager.IncrementScore(100);
        //currentLevelScore += 100;
        //scoreDisplay.text = (manager.totalScore.ToString());
        //levelScoreDisplay.text = (currentLevelScore.ToString());
        //}





    }

    public void UIScoreUpdate()
    {
        scoreDisplay.text = (manager.totalScore.ToString());
        levelScoreDisplay.text = (currentLevelScore.ToString());
        currentLevelScore = manager.totalScore;
    }

    public void ForcedLevelEnd()
    {
        StartCoroutine(ForceLevelEnd());
    }

    public IEnumerator ForceLevelEnd()
    {
        yield return new WaitForSeconds(2.0f);
        enemiesPresent = 0;
    }

    public void LeftTitleScreen()
    {
        manager.onTitleScreen = false;
    }

    public void WaveCheck()
    {
        // Next Level
        if (enemiesPresent <= 0)
        {
            currentSpawnWave += 1;
            if (currentSpawnWave > totalSpawnWaves)
            {
                int level = manager.levelNumber - 1;
                manager.levelScores[level] = currentLevelScore;

                print(manager.levelScores[level].ToString());

                manager.levelNumber += 1;
                SceneManager.LoadScene(newGameScene);
            }
            if (currentSpawnWave == 2 && !wave2trip)
            {
                var wave2 = waves[0].gameObject.GetComponent<PlayableDirector>();
                wave2.Play();
                wave2trip = true;
            }
            // Call function to instantiate next Timeline prefab which instantiates more enemies
            // + a script attached that will automatically tell CheckVariables.cs the new # of enemies present.
        }
    }
}
