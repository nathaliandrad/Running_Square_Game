using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public AudioSource speaker;

    void Update()
    {
        if (Input.GetKey(KeyCode.Return)){
            SceneManager.LoadScene(0);
        }
        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }
    }
}
