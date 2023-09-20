using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalGameTime : MonoBehaviour
{
    // TIMER DISPLAY
    public TextMeshProUGUI totalTime_Display;
    // Start is called before the first frame update
    private void Awake()
    {
        totalTime_Display = GameObject.Find("TotalTime_Display").GetComponent<TextMeshProUGUI>();
        DontDestroyOnLoad(this.gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
        float milliseconds = (Mathf.Floor(t * 100) % 100);
        int seconds = (int)(t % 60);
        t /= 60;
        int minutes = (int)(t % 60);
        t /= 60;
        int hours = (int)(t % 24);

        totalTime_Display.text = string.Format("{0}:{1}:{2}''{3}", hours.ToString("00"), minutes.ToString("00"), seconds.ToString("00"), milliseconds.ToString("00"));

    }
}
