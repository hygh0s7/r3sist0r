using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam : MonoBehaviour {
	public int gunDamage = 1;
	public float fireRate = 2f;
	public bool aiming = false;
	public Transform gunEnd;
	private WaitForSeconds shotDuration = new WaitForSeconds(1f);
	private float nextFire;
	public LineRenderer laserLine;
	private Transform playerTransform;
	private Vector3 rayOrigin;
	private Vector3 rayTarget;
	public float weaponRange = 10f;


	// Use this for initialization
	void Start () {
        laserLine = GetComponent<LineRenderer>();
        //gunAudio = GetComponent<AudioSource>();
        // Get a reference to the player's transform
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; 
    }

   	
	// Update is called once per frame
	void Update () {

        
        
		if (aiming && Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			StartCoroutine (ShotEffect());
			rayOrigin = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			rayTarget = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z);
			RaycastHit hit;
			laserLine.SetPosition(0, rayOrigin); 

			if (Physics.Raycast (rayTarget, gunEnd.transform.forward, out hit, weaponRange))
            {
                laserLine.SetPosition (1, rayTarget);
                Debug.DrawRay(rayOrigin, gunEnd.transform.forward * weaponRange, Color.green);
            }
            else
            {
                laserLine.SetPosition (1, rayOrigin + (gunEnd.transform.forward * weaponRange));
                Debug.DrawRay(rayOrigin, gunEnd.transform.forward * weaponRange, Color.green);
            }
		}

	}

	private IEnumerator ShotEffect()
	{
	    //gunAudio.Play();
	    laserLine.enabled = true;

	    yield return shotDuration;

	    laserLine.enabled = false;
	}

}
