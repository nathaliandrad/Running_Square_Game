using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    public float distance = 10.0f;
    public Transform targetObstacle;
    public GameObject invincible;
    public GameObject jump;

    private Vector3 pos;
    private int randomNum;

    void Start()
    {
        randomNum = Random.Range(1, 3);
        JumpingOrInvincibleObj();
    }

    public void SetPositionRandomly()
    {
        float x = Random.Range(-20, 20);
        float y = 1;
        float z = Random.Range(1000, 1500);
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }

    public void ToggleRendererAndCollider(GameObject obj, bool isEnabled)
    {
        obj.GetComponent<Renderer>().enabled = isEnabled;
        obj.GetComponent<Collider>().enabled = isEnabled;
    }

    public void JumpingOrInvincibleObj()
    {
        ToggleRendererAndCollider(jump, randomNum == 2);
        ToggleRendererAndCollider(invincible, randomNum == 1);
        SetPositionRandomly();
    }
}
