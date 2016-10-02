using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	Animator animator;
	public float Vertical;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Vertical = Input.GetAxisRaw ("Vertical");
		if(Vertical < 0){
			animator.SetBool("Walk_Down_key", true);
		}else{
			animator.SetBool("Walk_Down_key", false);
		}
	}
}
