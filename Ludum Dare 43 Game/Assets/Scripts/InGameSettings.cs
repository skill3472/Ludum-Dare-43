using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameSettings : MonoBehaviour {

	public GameObject pauseMenu;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnBackInGameButtonClick()
	{
		gameObject.SetActive(false);
		pauseMenu.SetActive(true);
	}
}
