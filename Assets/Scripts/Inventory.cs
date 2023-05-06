using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private Canvas canvas;
    private bool _isOpen;

    void Start()
    {
        canvas = GetComponent<Canvas>(); 
        canvas.enabled = false; 
    }

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.I))
    //    {
    //        Time.timeScale = canvas.enabled ? 1 : 0;
    //        canvas.enabled = !canvas.enabled;
            
    //    }


    //}
}
