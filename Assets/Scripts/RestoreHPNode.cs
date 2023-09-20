using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestoreHPNode : MonoBehaviour
{
    public HealthDisplay hP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            hP.currentHealth = 10;
            Destroy(gameObject);
        }
    }
}
