using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rage : MonoBehaviour {
	public Text scoretext;
	public GameObject TextObj;
	public GameObject enemy;
	public int realRage;
	// Use this for initialization
	void Start () {
		scoretext = TextObj.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		//realRage = rageEnemyScript.rage;
		scoretext.text = "RAGE: " + realRage.ToString();
	}
	public void UpdateRage()
	{
		//realRage = rageEnemyScript.rage;
		scoretext.text = "RAGE: " + realRage.ToString();
	}
}
