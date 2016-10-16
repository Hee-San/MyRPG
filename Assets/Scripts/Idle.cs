using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : StateMachineBehaviour {
	
	public float Vertical;
	public float Horizontal;

	public Animator Step;

	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

		if( Step == null ){
			Step = GameObject.Find("player/Step").GetComponent<Animator>();
		}

	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		Vertical = Input.GetAxisRaw ("Vertical");
		Horizontal = Input.GetAxisRaw ("Horizontal");
		if (Vertical < 0) {
			Step.SetBool ("D", true);
			Step.SetBool ("U", false);
			Step.SetBool ("R", false);
			Step.SetBool ("L", false);
		}
		if (Vertical > 0) {
			Step.SetBool ("D", false);
			Step.SetBool ("U", true);
			Step.SetBool ("R", false);
			Step.SetBool ("L", false);
		}
		if (Horizontal < 0) {
			Step.SetBool ("D", false);
			Step.SetBool ("U", false);
			Step.SetBool ("R", false);
			Step.SetBool ("L", true);
		}
		if (Horizontal > 0) {
			Step.SetBool ("D", false);
			Step.SetBool ("U", false);
			Step.SetBool ("R", true);
			Step.SetBool ("L", false);
		}
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
