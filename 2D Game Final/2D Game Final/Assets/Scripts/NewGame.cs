using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour
{

    public float reloadTime;
    private bool restart = false;
    private float resetTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (restart && resetTime <= Time.time)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void restartGame()
    {
        restart = true;
        resetTime = Time.time + reloadTime; 
    }
}
