using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

	public GameObject shopMenu;
	private bool isDisabled = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void Resume()
	{
		Time.timeScale = 1f;
		shopMenu.SetActive(false);
		isDisabled = true;
	}
	public void ShopMenuClick() 
	{
		if(isDisabled)
		{
			shopMenu.SetActive(true);
			isDisabled = false;
			Time.timeScale = 0f;
		}
		else
		{
			Resume();
		}
	}
}
