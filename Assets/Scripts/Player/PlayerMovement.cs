using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;
    public bool d;
    public bool a;
    public bool left;
    public bool right;
    public bool canJump;
    static public bool isInvincible;

    float timeCounter = 0f;
    float invincebleTime = 5f;
    public float distanceFromTarget;
   
    public Transform target;
    public Transform target2;
    public Transform target3;
    public Transform target4;

    public Transform target5;
    public Transform target6;
    public Transform target7;

    public Transform target8;
    public Transform target9;
    public Transform target10;

    public Transform target11;
    public Transform target12;
    public Transform target13;
    public Transform target14;
    public Transform target15;
    public Transform target16;

    public Transform target50;
    public Transform target51;
    public Transform target52;
    public Transform target53;
    public Transform target54;
    public Transform target55;
    public Transform target56;
    public Transform target57;
    public Transform target58;
    public Transform target59;
    public Transform target60;
    public Transform target61;
    public Transform target62;
    public Transform target63;
    public Transform target64;
    public Rigidbody rbObstacle;
    public Rigidbody rbObstacle2;
    public Rigidbody rbObstacle3;
    public Rigidbody rbObstacle4;

    public Rigidbody rbObstacle5;
    public Rigidbody rbObstacle6;
    public Rigidbody rbObstacle7;

    public Rigidbody rbObstacle8;
    public Rigidbody rbObstacle9;
    public Rigidbody rbObstacle10;

    public Rigidbody rbObstacle11;
    public Rigidbody rbObstacle12;
    public Rigidbody rbObstacle13;
    public Rigidbody rbObstacle14;
    public Rigidbody rbObstacle15;
    public Rigidbody rbObstacle16;

    public Rigidbody rbObstacle50;
    public Rigidbody rbObstacle51;
    public Rigidbody rbObstacle52;
    public Rigidbody rbObstacle53;
    public Rigidbody rbObstacle54;
    public Rigidbody rbObstacle55;
    public Rigidbody rbObstacle56;
    public Rigidbody rbObstacle57;
    public Rigidbody rbObstacle58;
    public Rigidbody rbObstacle59;
    public Rigidbody rbObstacle60;
    public Rigidbody rbObstacle61;
    public Rigidbody rbObstacle62;
    public Rigidbody rbObstacle63;
    public Rigidbody rbObstacle64;

    private void Start()
    {
        isInvincible = false;
        PlayerCollision.isCollided = false;
        distanceFromTarget = 150.0f;
        print("Num deaths: " + GameManager.deaths);
        GameManager.jumpCounts = GameManager.maxJumps;

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3))
        {
            rbObstacle.useGravity = false;
            rbObstacle2.useGravity = false;
            rbObstacle3.useGravity = false;
            rbObstacle4.useGravity = false;

            rbObstacle5.useGravity = false;
            rbObstacle6.useGravity = false;
            rbObstacle7.useGravity = false;

            rbObstacle8.useGravity = false;
            rbObstacle9.useGravity = false;
            rbObstacle10.useGravity = false;

            rbObstacle11.useGravity = false;
            rbObstacle12.useGravity = false;
            rbObstacle13.useGravity = false;
            rbObstacle14.useGravity = false;
            rbObstacle15.useGravity = false;
            rbObstacle16.useGravity = false;

            rbObstacle50.useGravity = false;
            rbObstacle51.useGravity = false;
            rbObstacle52.useGravity = false;
            rbObstacle53.useGravity = false;
            rbObstacle54.useGravity = false;
            rbObstacle55.useGravity = false;
            rbObstacle56.useGravity = false;
            rbObstacle57.useGravity = false;
            rbObstacle58.useGravity = false;
            rbObstacle59.useGravity = false;
            rbObstacle60.useGravity = false;
            rbObstacle61.useGravity = false;
            rbObstacle62.useGravity = false;
            rbObstacle62.useGravity = false;
            rbObstacle63.useGravity = false;
            rbObstacle64.useGravity = false;

        }



    }

    void FixedUpdate()
    {
        d = Input.GetKey(KeyCode.D);
        a = Input.GetKey(KeyCode.A);
        left = Input.GetKey(KeyCode.LeftArrow);
        right = Input.GetKey(KeyCode.RightArrow);
        canJump = Input.GetKeyDown(KeyCode.Space);

        if (GameManager.gameCanStart)
        {


        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        

       

        if (d) {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (right)
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (a)
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (left) {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (canJump && PlayerCollision.isCollided == true)
        {

            if(GameManager.jumpCounts > 0)
            {
                Jump();

            }

        }

        if(rb.position.y < -1) {

            FindObjectOfType<GameManager>().EndGame();
        }


        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3)) {

            if (Vector3.Distance(transform.position, target.position) <= distanceFromTarget)
            {
                rbObstacle.AddForce(Physics.gravity * rbObstacle.mass * 2);

            }

            if (Vector3.Distance(transform.position, target2.position) <= distanceFromTarget) {
                rbObstacle2.AddForce(Physics.gravity * rbObstacle2.mass * 2);

            }
            if (Vector3.Distance(transform.position, target3.position) <= distanceFromTarget)
            {
                rbObstacle3.AddForce(Physics.gravity * rbObstacle3.mass * 2);

            }
            if (Vector3.Distance(transform.position, target4.position) <= distanceFromTarget)
            {
                rbObstacle4.AddForce(Physics.gravity * rbObstacle4.mass * 2);

            }
            if (Vector3.Distance(transform.position, target5.position) <= distanceFromTarget)
            {
                rbObstacle5.AddForce(Physics.gravity * rbObstacle5.mass * 2);

            }
            if (Vector3.Distance(transform.position, target6.position) <= distanceFromTarget)
            {
                rbObstacle6.AddForce(Physics.gravity * rbObstacle6.mass * 2);

            }
            if (Vector3.Distance(transform.position, target7.position) <= distanceFromTarget)
            {
                rbObstacle7.AddForce(Physics.gravity * rbObstacle7.mass * 2);

            }
            if (Vector3.Distance(transform.position, target8.position) <= distanceFromTarget)
            {
                rbObstacle8.AddForce(Physics.gravity * rbObstacle7.mass * 2);

            }
            if (Vector3.Distance(transform.position, target9.position) <= distanceFromTarget)
            {
                rbObstacle9.AddForce(Physics.gravity * rbObstacle7.mass * 2);

            }
            if (Vector3.Distance(transform.position, target10.position) <= distanceFromTarget)
            {
                rbObstacle10.AddForce(Physics.gravity * rbObstacle10.mass * 2);

            }

            if (Vector3.Distance(transform.position, target11.position) <= distanceFromTarget)
            {
                rbObstacle11.AddForce(Physics.gravity * rbObstacle11.mass * 2);

            }
            if (Vector3.Distance(transform.position, target12.position) <= distanceFromTarget)
            {
                rbObstacle12.AddForce(Physics.gravity * rbObstacle12.mass * 2);

            }
            if (Vector3.Distance(transform.position, target13.position) <= distanceFromTarget)
            {
                rbObstacle13.AddForce(Physics.gravity * rbObstacle13.mass * 2);

            }
            if (Vector3.Distance(transform.position, target14.position) <= distanceFromTarget)
            {
                rbObstacle14.AddForce(Physics.gravity * rbObstacle14.mass * 2);

            }
            if (Vector3.Distance(transform.position, target15.position) <= distanceFromTarget)
            {
                rbObstacle15.AddForce(Physics.gravity * rbObstacle15.mass * 2);

            }
            if (Vector3.Distance(transform.position, target16.position) <= distanceFromTarget)
            {
                rbObstacle16.AddForce(Physics.gravity * rbObstacle16.mass * 2);

            }



            if (Vector3.Distance(transform.position, target50.position) <= distanceFromTarget)
            {
                rbObstacle50.AddForce(Physics.gravity * rbObstacle50.mass * 2);

            }
            if (Vector3.Distance(transform.position, target51.position) <= distanceFromTarget)
            {
                rbObstacle51.AddForce(Physics.gravity * rbObstacle51.mass * 2);

            }

            if (Vector3.Distance(transform.position, target52.position) <= distanceFromTarget)
            {
                rbObstacle52.AddForce(Physics.gravity * rbObstacle52.mass * 2);

            }

            if (Vector3.Distance(transform.position, target53.position) <= distanceFromTarget)
            {
                rbObstacle53.AddForce(Physics.gravity * rbObstacle53.mass * 2);

            }

            if (Vector3.Distance(transform.position, target54.position) <= distanceFromTarget)
            {
                rbObstacle54.AddForce(Physics.gravity * rbObstacle54.mass * 2);

            }

            if (Vector3.Distance(transform.position, target55.position) <= distanceFromTarget)
            {
                rbObstacle55.AddForce(Physics.gravity * rbObstacle55.mass * 2);

            }

            if (Vector3.Distance(transform.position, target56.position) <= distanceFromTarget)
            {
                rbObstacle56.AddForce(Physics.gravity * rbObstacle56.mass * 2);

            }

            if (Vector3.Distance(transform.position, target57.position) <= distanceFromTarget)
            {
                rbObstacle57.AddForce(Physics.gravity * rbObstacle57.mass * 2);

            }

            if (Vector3.Distance(transform.position, target58.position) <= distanceFromTarget)
            {
                rbObstacle58.AddForce(Physics.gravity * rbObstacle58.mass * 2);

            }

            if (Vector3.Distance(transform.position, target59.position) <= distanceFromTarget)
            {
                rbObstacle59.AddForce(Physics.gravity * rbObstacle59.mass * 2);

            }

            if (Vector3.Distance(transform.position, target60.position) <= distanceFromTarget)
            {
                rbObstacle60.AddForce(Physics.gravity * rbObstacle60.mass * 2);

            }

            if (Vector3.Distance(transform.position, target61.position) <= distanceFromTarget)
            {
                rbObstacle61.AddForce(Physics.gravity * rbObstacle61.mass * 2);

            }

            if (Vector3.Distance(transform.position, target62.position) <= distanceFromTarget)
            {
                rbObstacle62.AddForce(Physics.gravity * rbObstacle62.mass * 2);

            }
            if (Vector3.Distance(transform.position, target63.position) <= distanceFromTarget)
            {
                rbObstacle63.AddForce(Physics.gravity * rbObstacle63.mass * 2);

            }
            if (Vector3.Distance(transform.position, target64.position) <= distanceFromTarget)
            {
                rbObstacle64.AddForce(Physics.gravity * rbObstacle64.mass * 2);

            }

        }
        }

    }

    public void Jump()
    {
        GameManager.jumpCounts -= 1;
        Debug.Log("Pressing space to jump");
        rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        

    }


    public void InvinciblePlayer()
    {
        if (timeCounter < invincebleTime)
        { 
            transform.Rotate(0, 0, 10);
            gameObject.SetActive(false);

            timeCounter += Time.deltaTime;
        }



    }

}
