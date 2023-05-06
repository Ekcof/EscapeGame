using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour
{

    private Canvas canvas;
    private bool _isOpen;

    void Start()
    {
        canvas = GetComponent<Canvas>(); 
        canvas.enabled = false; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           Time.timeScale = canvas.enabled ? 1 : 0;
           canvas.enabled = !canvas.enabled;
            
       }


    }
}
