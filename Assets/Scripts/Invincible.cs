using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincible : MonoBehaviour
{
    [SerializeField] private float invincibilityDurationSecs = 1.5f;
    private float invincibilityDeltaTime = 0.07f;
    public bool isInvincible = false;
    [SerializeField] GameObject player;
    [SerializeField] GameObject mesh;
    private bool meshActive = true;
  

    private void Awake()
    {
        
    }

    private void Update()
    {
        if (meshActive)
        {
            mesh.SetActive(true);
        }

        if (!meshActive)
        {
            mesh.SetActive(false);
        }
    }
    public IEnumerator TempInvincibility()
    {
        isInvincible = true;
        Debug.Log("Turned invincible!");

        for (float i = 0; i < invincibilityDurationSecs; i += invincibilityDeltaTime)
        {
            if (meshActive)
            {
                mesh.SetActive(false);
                
            }
            else
            {
                mesh.SetActive(true);
            }
            yield return new WaitForSeconds(invincibilityDeltaTime);
        }

        Debug.Log("No longer invincible!");
        player.transform.localScale = Vector3.one;
        isInvincible = false;
    }
}
