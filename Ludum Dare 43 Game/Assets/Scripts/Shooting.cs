using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour {
	public float offset;
	public GameObject projectile;
	public Transform shootingPoint;
	AudioSource pistolShot;
	public Guns currentWeapon;
	public Guns[] listOfGuns;
	public Text GunText;
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
    		if(Time.timeScale != 0)
        	{
   				Instantiate(projectile,shootingPoint.position,shootingPoint.rotation);
   				pistolShot.Play();
       		}

    	}
 	  	if(Input.GetMouseButtonDown(2))
    	{
    		currentWeapon = new Guns();
    		currentWeapon = SelectGun("nameoftheweapon");
    	}

	}	
    public Guns SelectGun (string pName)
    {

    	Guns aux = new Guns();
    	for(int i=0;i<=listOfGuns[i].length;i++)
    	{
    		auxgun = listOfGuns[i];
    		if(aux.name.equals(pName))
    		{
    			return listOfGuns[i];
    			aux = listOfGuns[i];
    			return aux.name;
    		}
    		return listOfGuns[i];

   		}
   		
    }

    			 		
 	
}

