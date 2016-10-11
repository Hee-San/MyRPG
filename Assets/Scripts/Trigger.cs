using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
	public float dist;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RayNextTile (Vector2.up);
		RayNextTile (Vector2.right);
		RayNextTile (Vector2.down);
		RayNextTile (Vector2.left);
	}

	public void RayNextTile(Vector2 vec){
		RaycastHit2D hit = Physics2D.Raycast(transform.position, vec, distance:dist);
		if (hit.collider != null) {
			Debug.Log (hit.transform.name);
			switch (hit.transform.tag) {
			case "Water":
				//PlayerMoveのBoolの値変更
				break;
			}
		}
	}
}
