using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	public float offset;
	public GameObject projectile;
	public Transform shootingPoint;
	private bool isPressed = false;
	AudioSource pistolShot;
	// Use this for initialization
	void Start () {
		pistolShot = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		//Weapon rotation
		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        //Shooting
        if(Input.GetMouseButtonDown(0))
        {
        	if(isPressed == false)
        	{
        		Instantiate(projectile,shootingPoint.position,shootingPoint.rotation);
        		pistolShot.Play();
        		isPressed = true;
        	}
        }
        if(Input.GetMouseButtonUp(0))
        {
        	isPressed = false;
        }
	}
}
