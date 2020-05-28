using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Renderer rend;
    Color col;
    Vector4 originalColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        col.r = 0.1596654f;
        col.g = 0.6420088f;
        col.b = 0.8679245f;
        col.a = 0.6f;
        originalColor = GetComponent<Renderer>().material.color;
    }

    void Update()
    {
      
        if (Timer.timerOn | Timer.timerOnJump)
        {
            rend.material.SetColor("_Color", col);
        }
        else
        {
            rend.material.SetColor("_Color", originalColor);
        }
       
    }
}
