using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    public Camera camera;


    public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public float duration = 3.0f;

    private void Start()
    {
        camera = GetComponent<Camera>();
        camera.clearFlags = CameraClearFlags.SolidColor;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        //setting duration of frame
        float t = Mathf.PingPong(Time.time * 5f, duration) / duration;

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1)) {
            //setting Camera background color
            if (GameManager.gameCanStart)
            {
                camera.backgroundColor = Color.Lerp(color1, color2, t);
            }
            
        }

       else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2))
        {
            if (GameManager.gameCanStart)
            {
            camera.backgroundColor = Color.Lerp(Color.grey, Color.black, t);
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3))
        {
            if (GameManager.gameCanStart)
            {
            camera.backgroundColor = Color.Lerp(Color.yellow, Color.magenta, t);
            }
        }

    }
}
