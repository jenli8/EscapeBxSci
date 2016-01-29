using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour {
	
	public Animation SlimeAnimator; 
	public GameObject slime; 
	float timer= 200f; 
	public int health = 5;

	// Use this for initialization
	void Start () {
		
		//SlimeAnimator = GetComponent<Animation> (); 
	}
	
	// Update is called once per frame
	void Update () {
		/*toggleAnimations (); 
		timer -= 1.0f; 
		slime.GetComponent<Rigidbody>().AddForce (transform.forward * 2);*/
	}
	/*	
	void toggleAnimations() {
		if (timer % 99 == 10) {
			SlimeAnimator.Play ("Attack");
		} else {
			SlimeAnimator.Play("Wait");  
		}
	}
*/
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("book")) {
			health -= 1;
			SlimeAnimator.Play ("Damage");
			if (health == 0) {
				SlimeAnimator.Play ("Dead");
				Destroy (gameObject);
			}
			Destroy (other.gameObject);
		}
	}
}
