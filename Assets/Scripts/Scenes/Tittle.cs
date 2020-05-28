using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tittle : MonoBehaviour
{
    public int nextScene;
    public AudioSource speaker;
    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        speaker = GetComponent<AudioSource>();
        speaker.Play(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return)) {

            SceneManager.LoadScene(nextScene);
        }
        if (Input.GetKey(KeyCode.Space)) {
            SceneManager.LoadScene(5);
        }

        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }


    }
}
