using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour {
	
	public Animation SlimeAnimator; 
	public GameObject slime; 
	bool isAttacking= false; 
	float timer= 200f; 
	// Use this for initialization
	void Start () {
		
		//SlimeAnimator = GetComponent<Animation> (); 
	}
	
	// Update is called once per frame
	void Update () {
		toggleAnimations (); 
		timer -= 1.0f; 
		slime.GetComponent<Rigidbody>().AddForce (transform.forward * 2); 
	}
	
	void toggleAnimations() {
		if(timer % 99 == 10) {
			SlimeAnimator.Play("Attack");  
			isAttacking= true; 
		}
	}
}
