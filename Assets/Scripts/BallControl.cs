using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

	public float Xforce;
	public float Yforce;
	// Use this for initialization
	void Start () {
		float randomNumber = Random.Range (0, 2);
		if (randomNumber < 0.5) {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2(Xforce, Yforce));
		} else {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-Xforce, -Yforce));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col){
		//Rigidbody2D newVelocity = GetComponent<Rigidbody2D> ("player1");
		//Debug.Log ("newVelocity");
	}
}
