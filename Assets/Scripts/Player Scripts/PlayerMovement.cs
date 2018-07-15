using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float shipSpeed = 5f;
	public float rotationSpeed = 300f;
	private Rigidbody2D rigidBody;

	void Awake(){
		rigidBody = GetComponent<Rigidbody2D>();
	}

	void Start () {

	}
	
	void Update () {
		ShipTurn();
	}

	void ShipTurn(){

		Quaternion rotation = transform.rotation;
		float z = rotation.eulerAngles.z;
		z -= Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
		rotation = Quaternion.Euler(0,0,z);
		transform.rotation = rotation;
	}
}
