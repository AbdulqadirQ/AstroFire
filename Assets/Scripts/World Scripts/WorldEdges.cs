using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldEdges : MonoBehaviour {

	private GameObject object_in_collision;
	private string edge;

	void OnTriggerEnter2D(Collider2D target){
		if(target){
			object_in_collision = target.gameObject;
			float xPos = object_in_collision.transform.position.x;
			float yPos = object_in_collision.transform.position.y;

			edge = gameObject.name;

			if(edge == "TopEdge"){
				object_in_collision.transform.position = new Vector3(xPos,-5.5f,0);
			}else if(edge == "BottomEdge"){
				object_in_collision.transform.position = new Vector3(xPos,5.5f,0);
			}else if(edge == "LeftEdge"){
				object_in_collision.transform.position = new Vector3(9f,yPos,0);
			}else if(edge == "RightEdge"){
				object_in_collision.transform.position = new Vector3(-9f,yPos,0);
			}
		}
	}
}
