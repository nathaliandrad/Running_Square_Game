using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundMusic : MonoBehaviour
{

    public AudioSource speaker;
    public AudioClip music1;
    public AudioClip music2;
    public AudioClip music3;


    // Start is called before the first frame update
    void Start()
    {
        speaker = GetComponent<AudioSource>();
        //speaker.Play();



        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        {

            StartCoroutine("Delay");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2))
        {
            StartCoroutine("Delay2");
           
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3))
        {
            StartCoroutine("Delay3");
        
        }

    }

    IEnumerator Delay()
    {
 
        yield return new WaitForSeconds(3);
        speaker.PlayOneShot(music1, 1);

    }
    IEnumerator Delay2()
    {

        yield return new WaitForSeconds(3);
        speaker.PlayOneShot(music2, 1);

    }
    IEnumerator Delay3()
    {

        yield return new WaitForSeconds(3);
        speaker.PlayOneShot(music3, 1);

    }
}
