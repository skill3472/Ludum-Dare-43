using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodEnding : MonoBehaviour {

	public GameObject UI1;
	public GameObject UI2;
	public GameObject UI3;
	public GameObject UI4;
	public GameObject UI5;
	public bool cutscene;

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
		cutscene = true;
	}
}
