using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPopulation : MonoBehaviour
{
    public int waveEnemyCount;
    // Start is called before the first frame update
    void Awake()
    {
        var variables = FindObjectOfType<CheckVariables>();
        variables.enemiesPresent = waveEnemyCount;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
