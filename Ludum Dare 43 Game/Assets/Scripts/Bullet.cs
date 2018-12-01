using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	private Rigidbody2D rb;
	[SerializeField]private int bulletSpeed = 500;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		Destroy(gameObject,2);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(transform.right * bulletSpeed);
	}
}
