using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool active;
    bool isPaused;
    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 1;
        isPaused = false;
        //canvas = GetComponent<Canvas>();
        //canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Pausar();
        
    }

   public void Pausar()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            Time.timeScale = 0f;
            isPaused = true;


            //active = !active;
            //canvas.enabled = active;
            //Time.timeScale = (active) ? 0 : 1f;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            Time.timeScale = 1f;
            isPaused = false;
        }

    }
}
