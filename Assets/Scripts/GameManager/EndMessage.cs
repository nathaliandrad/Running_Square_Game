using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMessage : MonoBehaviour
{
    public GameObject endMessage;
    private void Start()
    {
        SetGameObjectOff();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            gameObject.SetActive(false);
            endMessage.gameObject.SetActive(true);
        }
    }
    public void SetGameObjectOff() {
        endMessage.gameObject.SetActive(false);
    }


}
