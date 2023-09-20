using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyCurrentHP = 1;
    public int enemyTotalHP = 1;
    bool isDead;
    public CheckVariables variables;
    // Start is called before the first frame update
    void Awake()
    {
        enemyCurrentHP = enemyTotalHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCurrentHP <= 0 && !isDead)
        {
            isDead = true;
            var scoreScript = FindObjectOfType<PersistentManager>();
            var variables = FindObjectOfType<CheckVariables>();
            for (int i = 0; i < enemyTotalHP; i++)
            {
                scoreScript.IncrementScore(100);
                variables.currentLevelScore = variables.currentLevelScore + 100;
                variables.UIScoreUpdate();
            }
            variables.enemiesPresent -= 1;
            variables.WaveCheck();
            print(variables.enemiesPresent + " are present. " + this.gameObject.name + " has been defeated.");
            Destroy(this.gameObject);
        }
    }

    public void OnHit()
    {
        // print("Enemy -1 HP/" + enemyCurrentHP + "/" + enemyTotalHP);
        enemyCurrentHP -= 1;
        // trigger hit animation
    }
}
