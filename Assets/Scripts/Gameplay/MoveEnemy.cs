using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 2;
    public bool stopEnabled;
    public float stoppingDistance;
    bool isDestroying;
    //public bool isMoving = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (stopEnabled)
        {
            if (transform.position.z <= stoppingDistance)
            {
                Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, stoppingDistance);
                transform.position = newPosition;
                //isMoving = false;
            }
        }

        if (transform.position.z <= 0f)
        {
            if (!isDestroying)
            {
                Destroy(gameObject, 6);
                print("Enemy self-destruct sequence initiating...");
                StartCoroutine(ForcedReduceEnemy());
                isDestroying = true;
            }


        }
    }

    public IEnumerator ForcedReduceEnemy()
    {
        yield return new WaitForSeconds(5.0f);
        var variables = FindObjectOfType<CheckVariables>();
        variables.enemiesPresent -= 1;
        print(variables.enemiesPresent + " are present. " + this.gameObject.name + " has died off-screen.");
        variables.WaveCheck();
    }

}
