using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour {

	public int lifePoints = 50;
	public Text LifeText;
	public GameObject explosion;
	public bool isDead = false;
	private GameObject x;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		LifeText.text = "LIFE " + lifePoints.ToString();
		if(lifePoints <= 0)
		{
			if(isDead != true)
			{
				isDead = true;
				x = Instantiate(explosion,transform.position,transform.rotation);
				Destroy(x,2f);
				Destroy(gameObject);
			}
		}
	}
}
