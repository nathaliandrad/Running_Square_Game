using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Renderer rend;
    Color colGreen;
    Color colPink;
    Vector4 originalColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        colGreen.r = 0.3506946f;
        colGreen.g = 1;
        colGreen.b = 0.2971698f;
        colGreen.a = 0.6f;


        colPink.r = 1;
        colPink.g = 0.0990566f;
        colPink.b = 0.9433959f;
        colPink.a = 0.6f;
        originalColor = GetComponent<Renderer>().material.color;
    }

    public void Update()
    {
      
        if (Timer.timerOn)
        {
            rend.material.SetColor("_Color", colGreen);
        }
        else if (Timer.timerOnJump)
        {
            rend.material.SetColor("_Color", colPink);
        }

        else
        {
            rend.material.SetColor("_Color", originalColor);
        }
       
    }
}
