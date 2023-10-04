using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float targetTimeInvincible = 6.0f;
    public Text timerTextInvincible;
    private float secondsInvincible;
    private bool timerOnInvincible;
    public float stopClock = 0.0f;

    public float targetTimeJump = 11.0f;
    public Text timerTextJump;
    private float secondsJump;
    private bool timerOnJump;

    public Text jumpingText;
    public Text invincibleText;

    void Start()
    {
        timerOnInvincible = false;
        timerTextInvincible.text = "";

        timerOnJump = false;
        timerTextJump.text = "";
    }

    void Update()
    {
        UpdateTimer(timerOnInvincible, targetTimeInvincible, ref secondsInvincible, timerTextInvincible, invincibleText);
        UpdateTimer(timerOnJump, targetTimeJump, ref secondsJump, timerTextJump, jumpingText);
    }

    void UpdateTimer(bool timerOn, float targetTime, ref float seconds, Text timerText, Text statusText)
    {
        if (timerOn)
        {
            targetTime -= Time.deltaTime;
            seconds = Mathf.RoundToInt(targetTime % 60);
            timerText.text = seconds.ToString();

            if (seconds < stopClock)
            {
                timerText.text = "";
                statusText.text = "";
                timerOn = false;
            }
        }
    }
}
