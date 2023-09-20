using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursorPolice : MonoBehaviour
{
    void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {
            Cursor.lockState = CursorLockMode.Confined;
            Debug.Log("Application is focused");
        }
        else
        {
            Debug.Log("Application lost focus");
        }
    }
}
