using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	public float offset;
	public GameObject projectile;
	public Transform shootingPoint;
	private bool isPressed = false;
	// Use this for initialization
	void Start () {
		
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
        		isPressed = true;
        	}
        }
        if(Input.GetMouseButtonUp(0))
        {
        	isPressed = false;
        }
	}
}
