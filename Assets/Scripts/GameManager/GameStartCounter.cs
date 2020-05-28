using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartCounter : MonoBehaviour
{
    public Text startCountText;
    public float targetTime;
    public float secondsClock;
    public AudioSource speaker;
    public AudioClip counterSound;

    void Start()
    {
        speaker.PlayOneShot(counterSound, 1);
        targetTime = 3.0f;
        StartCoroutine(CountDown(3));
    }
    void Update()
    {
        SetClock();
        if(secondsClock < 1)
        {
            startCountText.text = "run";
        }
        if (GameManager.gameCanStart)
        {
            startCountText.text = "";
        }
    }

    IEnumerator CountDown(int seconds)
    {
        int count = seconds;

        while(count > 0)
        {
            yield return new WaitForSeconds(1);
            count--;
        }
        StartGame();

    }
    public void StartGame()
    {
        GameManager.gameCanStart = true;
    }


    public void SetClock()
    {
        targetTime -= Time.deltaTime;
        secondsClock = Mathf.RoundToInt(targetTime % 60);
        startCountText.text = secondsClock.ToString();
    }

}
