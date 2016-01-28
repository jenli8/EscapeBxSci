using UnityEngine;
using System.Collections;

public class Sounds : MonoBehaviour {

	public AudioClip[] audios= new AudioClip[2]; 
	public GameObject slime; 
	AudioSource ActionAudio; 
	int timer= 500;
	// Use this for initialization
	void Start () { 
		ActionAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer -= 1; 

		if (Input.GetButtonDown ("Fire1")) {
			ActionAudio.clip= audios[1]; 
			ActionAudio.Play (); 
		}
		if(timer % 99 == 10) {
			ActionAudio.clip= audios[0]; 
			ActionAudio.Play(); 
		} 
	}
}
