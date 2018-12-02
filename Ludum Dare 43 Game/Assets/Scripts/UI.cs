using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	public GameObject shopMenu;
	[SerializeField]private GameObject gm;
	private bool isDisabled = true;
	private WaveSpawner ws;
	public Text waveText;
	// Use this for initialization
	void Start () {
		ws = gm.GetComponent<WaveSpawner>();
	}
	
	// Update is called once per frame
	void Update () {
		waveText.text = ws.CurrentWaveName;
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
