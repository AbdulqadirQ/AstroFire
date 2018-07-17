using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float shipAcceleration = 0.1f;
	public float rotationSpeed = 300f;
	private Rigidbody2D rigidBody;

	void Awake(){
		rigidBody = gameObject.GetComponent<Rigidbody2D>();
		rigidBody.gravityScale = 0.0f;
	}

	void Start () {

	}
	
	void Update () {
		ShipTurn();
		ShipMove();
	}

	void ShipMove(){
		// ALTERNATIVE:
		// float v = Input.GetAxis("Vertical");
		// if(v>0){
		// 	// transform.Translate(Vector3.up * shipAcceleration * Time.smoothDeltaTime * v);
		// 	GetComponent<Rigidbody2D>().AddForce(transform.right * shipAcceleration);
		// }

		// FIXME: There's no limit to acceleration - ship can continuously speed up
		if(Input.GetKey(KeyCode.W)){
			rigidBody.AddForce(
					transform.up * shipAcceleration, ForceMode2D.Impulse);			
		}


	}

	// FIXME: why does the ship start turning clockwise like nuts when
	// hit by an astroid??
	void ShipTurn(){

		Quaternion rotation = transform.rotation;
		float z = rotation.eulerAngles.z;
		z -= Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
		rotation = Quaternion.Euler(0,0,z);
		transform.rotation = rotation;
	}
}
