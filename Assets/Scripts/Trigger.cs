﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		switch (other.gameObject.tag) {
		case "Water":
			//PlayerMoveのBoolの値変更
			break;
		}
	}
}
