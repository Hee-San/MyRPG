using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	Animator animator;
	public float Vertical;
	public float Horizontal;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Vertical = Input.GetAxisRaw ("Vertical");
		Horizontal = Input.GetAxisRaw ("Horizontal");
		if(Vertical < 0){
			animator.SetBool("Walk_Down_key", true);
		}else{
			animator.SetBool("Walk_Down_key", false);
		}
		if(Vertical > 0){
			animator.SetBool("Walk_Up_key", true);
		}else{
			animator.SetBool("Walk_Up_key", false);
		}
		if(Horizontal < 0){
			animator.SetBool("Walk_Left_key", true);
		}else{
			animator.SetBool("Walk_Left_key", false);
		}
		if(Horizontal > 0){
			animator.SetBool("Walk_Right_key", true);
		}else{
			animator.SetBool("Walk_Right_key", false);
		}
	}
}
