
using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
 
    public PlayerMovement movement;
    public GameObject barrier;
    public GameObject obstacleDrop;

    public KeyCode powerOn;
    public float powerNum;

    public static bool isCollided;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle") {

            movement.enabled = false;
            print("Number of deaths: " + GameManager.deaths);
            FindObjectOfType<GameManager>().EndGame();

        }
        
        if (collisionInfo.collider.tag == "ObstacleDrop") {
            movement.enabled = false;
            print("Number of deaths: " + GameManager.deaths);
            FindObjectOfType<GameManager>().EndGame();
        }
        if(collisionInfo.collider.tag == "Ground")
        {
            GameManager.jumpCounts = GameManager.maxJumps;
        }


    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpecialPower")) {
            InvokeRepeating("InvinciblePlayer", 0f,0.001f);
            StartCoroutine(StopPowerProcess());
        }

        //colliding with JumpingPower
        if (other.gameObject.CompareTag("JumpingPlayer"))
        {
              isCollided = true;
            InvokeRepeating("JumpingPlayerPower", 0f, 0.001f);
            StartCoroutine(StopJumpingProcess());
            print("Colliding with special Power");
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("SpecialPower"))
        {
            Timer.timerOn = true;
            other.gameObject.GetComponent<Renderer>().enabled = false;


        }
        if (other.gameObject.CompareTag("JumpingPlayer"))
        {
            Timer.timerOnJump = true;
            other.gameObject.GetComponent<Renderer>().enabled = false;
        }
    }



    IEnumerator StopPowerProcess() {
        yield return new WaitForSeconds(5.5f);
        Physics.IgnoreLayerCollision(9, 10,false);
        CancelInvoke();
    }

    IEnumerator StopJumpingProcess()
    {
        yield return new WaitForSeconds(10.5f);
         isCollided = false;
        CancelInvoke();
        print("JumpingPower");
    }

    public void InvinciblePlayer()
    {
        Physics.IgnoreLayerCollision(9, 10);

        transform.Rotate(0, 10, 0);
    }




    public void JumpingPlayerPower()
    {
        isCollided = true;
        transform.Rotate(0, 10, 0);

    }

}
