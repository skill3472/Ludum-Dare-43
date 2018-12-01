using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {

	[SerializeField]private int hp = 5;
	AudioSource hitSound;
	// Use this for initialization
	void Start () {
		hitSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.right * Time.deltaTime);
		if(hp <= 0)
		{
			//rage = rage + 10;
			GameObject.Find("Game Manager").GetComponent<Rage>().realRage += 10;
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log("COL!");
		if(col.gameObject.tag == "Bullet")
		{
			Destroy(col.gameObject);
			hp = hp - 1;
			hitSound.Play();
		}
	}
	void OnCollisionEnter2D(Collision2D colll)
	{

		if(colll.gameObject.tag == "Bunker")
		{
			Debug.Log("OOOF!");
			colll.gameObject.GetComponent<Life>().lifePoints -= 10;
			Destroy(gameObject);
		}
	}
}
