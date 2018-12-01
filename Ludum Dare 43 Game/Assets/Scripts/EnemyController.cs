using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log("COL!");
		if(col.gameObject.tag == "Bullet")
		{
			hp = hp - 1;
			Destroy(col.gameObject);
			hitSound.Play();
		}
	}
}
