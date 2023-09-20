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
    public GameObject GenericEnemyStop;
    public GameObject HardEnemy;
    public GameObject HardEnemy2;

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
            print(variables.enemiesPresent + " enemies present. Generic Enemy spawned in lane 3.");
        }
        else if (lane == 2)
        {
            var enemy = Instantiate(GenericEnemy, enemySpawnPoint_lane2.position, enemySpawnPoint_lane2.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
            print(variables.enemiesPresent + " enemies present. Generic Enemy spawned in lane 2.");
        }
        else if (lane == 1)
        {
            var enemy = Instantiate(GenericEnemy, enemySpawnPoint_lane1.position, enemySpawnPoint_lane1.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
            print(variables.enemiesPresent + " enemies present. Generic Enemy spawned in lane 1.");
        }

    }
    public void SpawnGenericEnemyStop(int lane)
    {
        var variables = FindObjectOfType<CheckVariables>();
        if (lane == 3)
        {
            var enemy = Instantiate(GenericEnemyStop, enemySpawnPoint_lane3.position, enemySpawnPoint_lane3.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
            print(variables.enemiesPresent + " enemies present. Generic Enemy with a stop spawned in lane 3.");
        }
        else if (lane == 2)
        {
            var enemy = Instantiate(GenericEnemyStop, enemySpawnPoint_lane2.position, enemySpawnPoint_lane2.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
            print(variables.enemiesPresent + " enemies present. Generic Enemy with a stop spawned in lane 2.");
        }
        else if (lane == 1)
        {
            var enemy = Instantiate(GenericEnemyStop, enemySpawnPoint_lane1.position, enemySpawnPoint_lane1.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
            print(variables.enemiesPresent + " enemies present. Generic Enemy with a stop spawned in lane 1.");
        }

    }
    public void SpawnHardEnemy(int lane)
    {
        var variables = FindObjectOfType<CheckVariables>();
        if (lane == 3)
        {
            var enemy = Instantiate(HardEnemy, enemySpawnPoint_lane3.position, enemySpawnPoint_lane3.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
            print(variables.enemiesPresent + " enemies present. HardEnemy spawned in lane 3.");
        }
        else if (lane == 2)
        {
            var enemy = Instantiate(HardEnemy, enemySpawnPoint_lane2.position, enemySpawnPoint_lane2.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
            print(variables.enemiesPresent + " enemies present. HardEnemy spawned in lane 2.");
        }
        else if (lane == 1)
        {
            var enemy = Instantiate(HardEnemy, enemySpawnPoint_lane1.position, enemySpawnPoint_lane1.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
            print(variables.enemiesPresent + " enemies present. HardEnemy spawned in lane 1.");
        }
    }
    public void SpawnHardEnemy2(int lane)
    {
        var variables = FindObjectOfType<CheckVariables>();
        if (lane == 3)
        {
            var enemy = Instantiate(HardEnemy2, enemySpawnPoint_lane3.position, enemySpawnPoint_lane3.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
            print(variables.enemiesPresent + " enemies present. HardEnemy2 spawned in lane 3.");
        }
        else if (lane == 2)
        {
            var enemy = Instantiate(HardEnemy2, enemySpawnPoint_lane2.position, enemySpawnPoint_lane2.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
            print(variables.enemiesPresent + " enemies present. HardEnemy2 spawned in lane 2.");
        }
        else if (lane == 1)
        {
            var enemy = Instantiate(HardEnemy2, enemySpawnPoint_lane1.position, enemySpawnPoint_lane1.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
            print(variables.enemiesPresent + " enemies present. HardEnemy2 spawned in lane 1.");
        }
    }

    public void SpawnFinalEnemy(int enemyID)
    {
        var variables = FindObjectOfType<CheckVariables>();
        if (enemyID == 0)
        {
            var enemy = Instantiate(GenericEnemy, enemySpawnPoint_lane2.position, enemySpawnPoint_lane2.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
            print("FINAL ENEMY SPAWN: " + variables.enemiesPresent + " enemies present in scene. Generic Enemy has spawned in lane 2.");
        }
        else if (enemyID == 1)
        {
            var enemy = Instantiate(HardEnemy, enemySpawnPoint_lane2.position, enemySpawnPoint_lane2.rotation);
            variables.enemiesPresent = variables.enemiesPresent + 1;
            print("FINAL ENEMY SPAWN: " + variables.enemiesPresent + " enemies present in scene. Hard Enemy has spawned in lane 2.");
        }
    }
    public void SetSpawnBool()
    {
        var variables = FindObjectOfType<CheckVariables>();
        variables.isEnemySpawned = true;
        print("bool isEnemySpawned is now true.");
    }
}
