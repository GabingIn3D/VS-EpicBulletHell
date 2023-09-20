using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public GameObject enemyBulletPrefab;
    public float bulletSpeed = 10;
    public float gunheat;
    public const float fireRate = 0.1f;
    [Header("Enemy Settings")]
    public bool playerControlled;
    public bool bigShoot;
    public float burstDelay;
    public float enemyFireRate;
    public int iterationCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gunheat > 0) gunheat -= Time.deltaTime;
        if (playerControlled)
        {
            if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Space))
            {
                if (gunheat <= 0)
                {
                    DoFire();
                    gunheat = fireRate;

                }

            }
        }
        if (bigShoot == true)
        {
            StartCoroutine(EnemyShoot());
        }
       
    }

    void DoFire()
    {
        if(playerControlled)
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
        else
        {
            var bullet = Instantiate(enemyBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }

    }

    IEnumerator EnemyShoot()
    {
        bigShoot = false;
        for (int i = 0; i < iterationCount; i++)
        {
            DoFire();
            yield return new WaitForSeconds(enemyFireRate);
        }
        yield return new WaitForSeconds(burstDelay);
        bigShoot = true;
    }
}
