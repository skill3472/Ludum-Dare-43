using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	public GameObject pauseMenu;
	private bool isDisabled = true;
	public GameObject settingsMenu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("escape"))
		{
			if(isDisabled)
			{
				pauseMenu.SetActive(true);
				isDisabled = false;
				Time.timeScale = 0f;
			}
			else
			{
				Resume();
			}
		}
	}
	public void Resume()
	{
		pauseMenu.SetActive(false);
		isDisabled = true;
		Time.timeScale = 1f;
	}
	public void OnSettingsInGameClick()
	{
		pauseMenu.SetActive(false);
		settingsMenu.SetActive(true);
	}
	public void OnQuitButton()
	{
		Debug.Log("Quit!");
		Application.Quit();
	}
}
