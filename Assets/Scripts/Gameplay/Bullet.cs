using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    public bool isPlayerBullet;
    // Start is called before the first frame update
    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy" && isPlayerBullet)
        {
            var enemyScript = other.gameObject.GetComponent<EnemyHealth>();
            enemyScript.OnHit();
            Destroy(gameObject);
            
        }
        if(other.gameObject.tag == "Player" )
        {
            var playerScript = other.gameObject.GetComponent<HealthDisplay>();
            playerScript.Damage();
            Destroy(gameObject);
        }
    }
}
