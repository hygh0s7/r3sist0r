using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneLight: MonoBehaviour
{
    // Interpolate light color between two colors back and forth
    public bool alarm = false;
    float duration = 1.0f;
    Color normal = new Color(1f, 0.92f, 0.016f, 1f);
    Color color0 = Color.red;
    Color color1 = Color.blue;

    Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
    }

    void Update()
    {
    	if(alarm){
	    	// set light color
	        float t = Mathf.PingPong(Time.time, duration) / duration;
	        lt.color = Color.Lerp(color0, color1, t);	
    	}
        else{
        	lt.color = normal;
        }
    }
}
