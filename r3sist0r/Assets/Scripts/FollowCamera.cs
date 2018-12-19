using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Reference to the player's transform. 
    public Transform player;
 
    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, 
            player.transform.position.y+4f, transform.position.z);
    }
}
