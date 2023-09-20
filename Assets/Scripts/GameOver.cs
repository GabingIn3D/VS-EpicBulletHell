
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] GameObject health;
    [SerializeField] string desiredScene;

    public void Start()
    {
        gameOverScreen.SetActive(false);
    }
    public void SetGameOver()
    {

        gameOverScreen.SetActive(true);
        health.SetActive(false);
        Time.timeScale = 0;
        
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        var scoreScript = FindObjectOfType<PersistentManager>();
        scoreScript.livesLost += 1;
        SceneManager.LoadScene(desiredScene);
        
    }

}