using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MutantEnemyController : MonoBehaviour {

	[SerializeField]private int hp = 5;
	AudioSource hitSound;
	// Use this for initialization
	void Start () {
		hitSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.right * Time.deltaTime/3);
		if(hp <= 0)
		{
			//rage = rage + 10;
			GameObject.Find("Game Manager").GetComponent<Rage>().realRage += 10;
			Destroy(gameObject);
		}
	}

/*	void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log(col.gameObject.name);
		if(col.gameObject.tag == "AK47")
		{
			Destroy(col.gameObject);
			hp = hp - 1;
			hitSound.Play();
		}
		else if(col.gameObject.tag == "Pistol")
		{
			Destroy(col.gameObject);
			hp = hp - 3;
			hitSound.Play();
		}
		else if(col.gameObject.tag == "Sniper")
		{
			Destroy(col.gameObject);
			hp = hp - 10;
			hitSound.Play();
		}
	}
*/	void OnCollisionEnter2D(Collision2D col)
	{

		if(col.gameObject.tag == "Bunker")
		{
			Debug.Log("OOOF!");
			col.gameObject.GetComponent<Life>().lifePoints -= 10;
			Destroy(gameObject);
		}
		Debug.Log(col.gameObject.name);
		if(col.gameObject.tag == "AK47")
		{
			Destroy(col.gameObject);
			hp = hp - 1;
			hitSound.Play();
		}
		if(col.gameObject.tag == "Pistol")
		{
			Destroy(col.gameObject);
			hp = hp - 3;
			hitSound.Play();
		}
		if(col.gameObject.tag == "Sniper")
		{
			Destroy(col.gameObject);
			hp = hp - 10;
			hitSound.Play();
		}
	}
}
