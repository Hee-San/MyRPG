using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	Animator animator;
	public float Vertical;
	public float Horizontal;
	public bool UpTrigger, DownTrigger, RightTrigger, LeftTrigger;
	private Component Trigger;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		UpTrigger 		= false;
		DownTrigger 	= false;
		RightTrigger 	= false;
		LeftTrigger 	= false;
	}
	
	// Update is called once per frame
	void Update () {
		Vertical = Input.GetAxisRaw ("Vertical");
		Horizontal = Input.GetAxisRaw ("Horizontal");
		if(Vertical < 0 && !GetComponent<Trigger> ().wall_down){
			animator.SetTrigger("Walk_Down_key");
		}else{
			animator.ResetTrigger("Walk_Down_key");
		}
		if(Vertical > 0 && !GetComponent<Trigger> ().wall_up){
			animator.SetTrigger("Walk_Up_key");
		}else{
			animator.ResetTrigger("Walk_Up_key");
		}
		if(Horizontal < 0 && !GetComponent<Trigger> ().wall_left){
			animator.SetTrigger("Walk_Left_key");
		}else{
			animator.ResetTrigger("Walk_Left_key");
		}
		if(Horizontal > 0 && !GetComponent<Trigger> ().wall_right){
			animator.SetTrigger("Walk_Right_key");
		}else{
			animator.ResetTrigger("Walk_Right_key");
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("trigger");
	}
}
