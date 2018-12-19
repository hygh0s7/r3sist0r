using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeOnTrigger : MonoBehaviour {
 
    public DroneAI DroneAi;
    public DroneLight Dronelight;
   
    void OnTriggerEnter2D(Collider2D o)
    {
        
        if (o.gameObject.tag == "Player")
        {
            DroneAi.inViewCone = true;
            Dronelight.alarm = true;
        }
    }
    
    void OnTriggerExit2D(Collider2D o)
    {
 
 
        if (o.gameObject.tag == "Player")
        {
            DroneAi.inViewCone = false;
            Dronelight.alarm = false;
        }
    }
}