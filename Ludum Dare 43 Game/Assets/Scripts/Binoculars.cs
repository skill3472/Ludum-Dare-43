using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Binoculars : MonoBehaviour {

	public Guns binocularsGun;
	public GameObject binoculars;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(binocularsGun.isUnlocked && Input.GetKeyDown("b"))
		{
			binoculars.SetActive(true);
		}
		if(binocularsGun.isUnlocked && Input.GetKeyUp("b"))
		{
			binoculars.SetActive(false);
		}
	}
}
