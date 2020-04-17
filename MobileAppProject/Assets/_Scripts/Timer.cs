using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float _timer = 0.0f; // Start time
    public Text timer = null;
    bool keepTiming; // Check to continue timer

    void Update()
    {
        _timer += Time.deltaTime;
        timer.text = _timer.ToString("0.00"); // Display timer on text

       /* if  (GameObject.FindObjectOfType<PlayerController>() == null) //Stop timer on death
        {
            
        }*/
    }    
}
