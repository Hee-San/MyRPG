using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
	public float dist;
	public bool wall_up, wall_right, wall_down, wall_left;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		wall_up = RayNextTile (Vector2.up);
		wall_right = RayNextTile (Vector2.right);
		wall_down = RayNextTile (Vector2.down);
		wall_left = RayNextTile (Vector2.left);
	}

	public bool RayNextTile(Vector2 vec){
		RaycastHit2D hit = Physics2D.Raycast(transform.position, vec, distance:dist);
		if (hit.collider != null) {
			Debug.Log (hit.transform.name);
			switch (hit.transform.tag) {
			case "Water":
				return true;
				break;
			}
		}
		return false;
	}
}
