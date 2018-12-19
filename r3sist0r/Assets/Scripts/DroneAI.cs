using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAI : MonoBehaviour {

	public float min = 2f;
    public float max = 3f;
    
    // Where is the player
    private Transform playerTransform;

    // FSM related variables
    private Animator animator;
    public bool chasing = false;

    //bool waiting = false;
    private float distanceFromTarget;
    public bool inViewCone;


    public void Start () {

        min = transform.position.x;
        max = transform.position.x + 3;


        // Get a reference to the player's transform
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
 
        // Get a reference to the FSM (animator)
        animator = gameObject.GetComponent<Animator>();

    }

    private void Update()
    {

         
        // If chasing get the position of the player and point towards it
        if (chasing)
        {
            transform.position = new Vector3(playerTransform.position.x, transform.position.y, transform.position.z);
            // rotateZombie();
        }
 
        // Unless the zombie is waiting then move
        else{
            transform.position = new Vector3(Mathf.PingPong(Time.time*2,max-min)+min, 
                transform.position.y, transform.position.z);
            //transform.Translate(walkSpeed * direction * Time.deltaTime, Space.World);
        }
        
    }
 
    private void FixedUpdate()
    {
        // Give the values to the FSM (animator)
        animator.SetFloat("distanceFromWaypoint", distanceFromTarget);
        animator.SetBool("playerInSight", inViewCone);
 
    }

 
    public void StopChasing()
    {
        chasing = false;
    }

    public void StartChasing()
    {
        chasing = true;
    }
 
}
