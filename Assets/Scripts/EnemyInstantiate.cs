using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstantiate : MonoBehaviour
{
    [Header("Enemy Spawning Positions")]
    public Transform enemySpawnPoint_lane1;
    public Transform enemySpawnPoint_lane2;
    public Transform enemySpawnPoint_lane3;
    [Header("Enemy Prefabs")]
    public GameObject GenericEnemy;
    public GameObject HardEnemy;

    public CheckVariables variables;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnGenericEnemy(int lane)
    {
        var variables = FindObjectOfType<CheckVariables>();
        if (lane == 3)
        {
            var enemy = Instantiate(GenericEnemy, enemySpawnPoint_lane3.position, enemySpawnPoint_lane3.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
        }
        else if (lane == 2)
        {
            var enemy = Instantiate(GenericEnemy, enemySpawnPoint_lane2.position, enemySpawnPoint_lane2.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
        }
        else if (lane == 1)
        {
            var enemy = Instantiate(GenericEnemy, enemySpawnPoint_lane1.position, enemySpawnPoint_lane1.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
        }

    }

    public void SpawnHardEnemy(int lane)
    {
        var variables = FindObjectOfType<CheckVariables>();
        if (lane == 3)
        {
            var enemy = Instantiate(HardEnemy, enemySpawnPoint_lane3.position, enemySpawnPoint_lane3.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
        }
        else if (lane == 2)
        {
            var enemy = Instantiate(HardEnemy, enemySpawnPoint_lane2.position, enemySpawnPoint_lane2.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
        }
        else if (lane == 1)
        {
            var enemy = Instantiate(HardEnemy, enemySpawnPoint_lane1.position, enemySpawnPoint_lane1.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
        }
    }

    public void SpawnFinalEnemy(int enemyID)
    {
        var variables = FindObjectOfType<CheckVariables>();
        if (enemyID == 0)
        {
            var enemy = Instantiate(GenericEnemy, enemySpawnPoint_lane2.position, enemySpawnPoint_lane2.rotation);
        }
        else if (enemyID == 1)
        {
            var enemy = Instantiate(HardEnemy, enemySpawnPoint_lane2.position, enemySpawnPoint_lane2.rotation);
        }
    }
}
