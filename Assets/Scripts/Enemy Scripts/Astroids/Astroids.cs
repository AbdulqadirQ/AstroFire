using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidsScript : MonoBehaviour {

	private Rigidbody2D rigidBody;

	void Awake(){
		rigidBody = gameObject.GetComponent<Rigidbody2D>();
		rigidBody.gravityScale = 0.0f;
	}

	void Start () {
		
	}
	
	void Update () {
		
	}
}
