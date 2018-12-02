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
	public Guns weapon1;
	public Guns weapon2;
	public Guns weapon3;
//	public Guns weapon4
	public Text GunText;
	private float nextTimeToFire = 0f;
	// Use this for initialization
	void Start () {
		pistolShot = GetComponent<AudioSource>();
		currentWeapon = weapon1;
	}
	
	// Update is called once per frame
	void Update () {
		//Weapon rotation
		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    	float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
    	transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
    	//Text setting
    	GunText.text = currentWeapon.name;
    	//Shooting
    	if(Input.GetMouseButton(0) && Time.time >= nextTimeToFire)
    	{
    		if(Time.timeScale != 0)
        	{
        		projectile = currentWeapon.bulletPrefab;
        		nextTimeToFire = Time.time + 1f/currentWeapon.fireRate;
   				Instantiate(projectile,shootingPoint.position,shootingPoint.rotation);
   				pistolShot.Play();
       		}

    	}
    	//Changing weapons
    		if((weapon1.isUnlocked) && Input.GetKeyDown("1"))
    		{
    			currentWeapon = weapon1;
    		}
    		if((weapon2.isUnlocked) && Input.GetKeyDown("2"))
    		{
    			currentWeapon = weapon2;
    		}
    		if((weapon3.isUnlocked) && Input.GetKeyDown("3"))
    		{
    			currentWeapon = weapon3;
    		}

	}	
/*    public Guns SelectGun (string pName)
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
*/
    			 		
 	
}

