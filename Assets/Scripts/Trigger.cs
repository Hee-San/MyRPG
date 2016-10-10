using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collider2D other){
		Debug.Log ("trigger");
		switch (other.gameObject.tag) {
		case "Water":
			//PlayerMoveのBoolの値変更
			Debug.Log ("trigger");
			break;
		}
	}
}
