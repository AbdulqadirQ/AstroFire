using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidSpawner : MonoBehaviour {

	public GameObject astroid;
	private Transform spawn;


	void Start () {

	// FIXME: make spawner universal for more astroids
		Vector3 spawn_location = transform.position;
		spawn_location[0] = -9;
		spawn_location[1] = 6;
		spawn_location[2] = 0;

		GameObject spawned_astroid = Instantiate(
			astroid, spawn_location, Quaternion.identity);
		spawned_astroid.GetComponent<Rigidbody2D>().AddForce(
					new Vector2(Random.Range(100f, 1000f), Random.Range(50f, 400f)));
	}
	
	void Update () {
		
	}
}
