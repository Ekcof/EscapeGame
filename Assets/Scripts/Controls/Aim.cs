using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    private Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            canvas.enabled = !canvas.enabled;
        }


    }
}