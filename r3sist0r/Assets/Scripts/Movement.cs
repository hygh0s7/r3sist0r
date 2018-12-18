using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float min = 2f;
    public float max = 3f;
    
    // Where is the player
    private Transform playerTransform;

    // FSM related variables
    private Animator animator;
    bool chasing = false;
    bool waiting = false;
    private float distanceFromTarget;
    public bool inViewCone;
 
    // Where is it going and how fast?
    Vector3 direction;
    private float walkSpeed = 2f;
    private float runSpeed = 3f; 
    private int currentTarget;    
    private Transform[] waypoints = null;

    void Start () {
       
        min = transform.position.x;
        max = transform.position.x + 3;
   
    }
   
    // Update is called once per frame
    void Update () {
        
        transform.position = new Vector3(Mathf.PingPong(Time.time*2,max-min)+min, transform.position.y, transform.position.z);
       
    }
}
