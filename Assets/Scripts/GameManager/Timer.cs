using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float targetTime;
    public Text timerText;
    public float seconds;
    public static bool timerOn;
    public float stopClock;

    public float targetTimeJump;
    public Text timerTextJump;
    public float seconds_jump;
    public static bool timerOnJump;

    public Text jumpingText;
    public Text invincibleText;

    void Start()
    {
        timerOn = false;
        targetTime = 6.0f;
        stopClock = 0;

        timerOnJump = false;
        targetTimeJump = 11.0f;
    }

    void Update()
    {
        timerText.text = "";
        timerTextJump.text = "";
        jumpingText.text = "";

        invincibleText.text = "";

        if (timerOn == true)
        {
            targetTime -= Time.deltaTime;
            seconds = Mathf.RoundToInt(targetTime % 60);
            timerText.text = seconds.ToString();
            SetInvincibleText();
            StopClock();

        }

        if (timerOnJump == true)
        {
            targetTimeJump -= Time.deltaTime;
            seconds_jump = Mathf.RoundToInt(targetTimeJump % 60);
            timerTextJump.text = seconds_jump.ToString();
            SetJumpingText();
            StopClock();

        }
    }

    public void StopClock()
    {
       
      
        if (seconds < stopClock) {
            timerText.text = "";
            invincibleText.text = "";
            timerOn = false;
        }

        if(seconds_jump < stopClock)
        {
            timerOnJump = false;
            timerTextJump.text = "";
            jumpingText.text = "";
        }
    }

    void SetJumpingText()
    {
        jumpingText.text = "Jump Freely";
    }

    void SetInvincibleText()
    {
        invincibleText.text = "Invincible Time";
    }

}
