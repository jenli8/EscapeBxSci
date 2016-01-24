using UnityEngine;
using System.Collections;

public class InstructionsDisplay : MonoBehaviour {

	private float timed;
	// Use this for initialization
	void Start () {
		timed = 10; 

	}
	
	// Update is called once per frame
	void Update () {
		timed -= Time.deltaTime; 
		if (timed <= 0) {
			gameObject.SetActive(false);
		}
	}
	
}
