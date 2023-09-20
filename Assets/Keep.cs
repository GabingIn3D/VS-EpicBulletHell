using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keep : MonoBehaviour
{
    private AudioSource backgroundMusic;
    // Start is called before the first frame update
    void Awake()
    {
        backgroundMusic = GetComponent<AudioSource>();
        var scoreScript = FindObjectOfType<PersistentManager>().GetComponent<PersistentManager>();
        if (scoreScript.musicBegun)
        {
            Cursor.visible = false;
            Destroy(gameObject);
        }
        else
        {
            backgroundMusic.Play();
            scoreScript.musicBegun = true;
        }
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
