using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidSpawner : MonoBehaviour {

	public GameObject astroid;
	private Vector3 magnitude;

	void Start () {
		SpawnAstroid();
		SpawnAstroid();
		SpawnAstroid();

	}

	// FIXME: Location nor magnitude seem randomised..
	void SpawnAstroid(){
		Vector3 spawn_location = transform.position;
		spawn_location = RandomiseSpawnLocations(spawn_location);

		GameObject spawned_astroid = Instantiate(
			astroid, spawn_location, Quaternion.identity);
		spawned_astroid.GetComponent<Rigidbody2D>().AddForce(
					RandomiseMagnitude());
	}

	Vector2 RandomiseMagnitude(){

		int[] positive_and_negative = {Random.Range(-5000, -10000), 
			Random.Range(5000, 10000)};

		int magnitude = positive_and_negative[Random.Range(0,1)];

		return new Vector2(magnitude, magnitude);
	}

	Vector3 RandomiseSpawnLocations(Vector3 spawn_location){
		int[] x_positions = {-9,9};
		int x_position = x_positions[Random.Range(1,2)];
		int y_position = Random.Range(-6,6);
		
		spawn_location[0] = x_position;
		spawn_location[1] = y_position;
		spawn_location[2] = 0;

		return spawn_location;
	}
	
	void Update () {
		
	}
}
