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
		wall_up = RayNextTile (Vector2.up, dist);
		wall_right = RayNextTile (Vector2.right, dist);
		wall_down = RayNextTile (Vector2.down, dist);
		wall_left = RayNextTile (Vector2.left, dist);
	}

	public bool RayNextTile(Vector2 vec, float distance){
		RaycastHit2D hit = Physics2D.BoxCast(transform.position + new Vector3(0,-4,0), new Vector2(4,4), 0, vec, distance:distance);
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
