﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GoodEnding : MonoBehaviour {

	public GameObject UI1;
	public GameObject UI2;
	public GameObject UI3;
	public GameObject UI4;
	public GameObject UI5;
	public GameObject GoodEndingButton;
	public bool cutscene = false;
	public PlayableDirector theGoodEnding;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void GoodEndingVoid()
	{
		UI1.SetActive(false);
		UI2.SetActive(false);
		UI3.SetActive(false);
		UI4.SetActive(false);
		UI5.SetActive(false);
		GoodEndingButton.SetActive(true);
		cutscene = true;
		theGoodEnding.Play();
	}
	public void GoodEndingClick()
	{
		theGoodEnding.Stop();
		SceneManager.LoadScene("Good ending");
	}
}
