using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	Rigidbody2D player;
	public KeyCode up;
	public KeyCode down;
	float speed = 10f;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (up)) {
			player.velocity = new Vector2 (0f, speed);
		} else if (Input.GetKey (down)) {
			player.velocity = new Vector2 (0f, -speed);
		} else {
			player.velocity = new Vector2 (0f, 0f);
		}
	}
}
