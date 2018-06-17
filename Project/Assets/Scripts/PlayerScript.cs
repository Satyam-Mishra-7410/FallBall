using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public int _Speed = 150;
	public int _JumpForce = 50;
	public Rigidbody2D _RigidBody;

	// Use this for initialization
	void Start () {
		_RigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * _Speed;
		float y = Input.GetAxis ("Vertical") * Time.deltaTime * _JumpForce;

		transform.Translate (x, 0.0f, 0.0f);
		//Vector2 addForce = new Vector2 (0.0f, transform.position.y + y);
		_RigidBody.AddForce (new Vector2(0, y), ForceMode2D.Impulse);
	}
}
