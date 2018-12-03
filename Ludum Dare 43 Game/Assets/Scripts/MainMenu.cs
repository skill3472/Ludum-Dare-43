using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPlayClick()
	{
		SceneManager.LoadScene("Game");
	}
	public void OnCreditsClick()
	{
		SceneManager.LoadScene("Credits");
	}
	public void OnQuitClick()
	{
		Application.Quit();
	}
}
