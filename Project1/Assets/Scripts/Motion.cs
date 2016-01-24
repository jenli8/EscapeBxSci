using UnityEngine;
using System.Collections;

public class Motion : MonoBehaviour {
	/*
	Vector3 pos1;
	Vector3 pos2;
	float radius;
	ConstantForce cf;
	Collider[] collsPos1;
	Collider[] collsPos2;*/
	ConstantForce cf;
	Rigidbody rb;
	float newZ;

	// Use this for initialization
	void Start () {
		/*cf = gameObject.GetComponent<ConstantForce>();
		radius = 50;

		pos1 = new Vector3(120.06f, 25.5f, 36.2f);
		pos2 = new Vector3(120.06f, 22.5f, 120f);

		collsPos1 = Physics.OverlapSphere (pos1, radius);
		collsPos2 = Physics.OverlapSphere (pos2, radius);*/
		cf = gameObject.GetComponent<ConstantForce>();
		rb = gameObject.GetComponent<Rigidbody>();
		newZ = cf.force.z;
	}

	// Update is called once per frame
	void Update () {
		/*collsPos1 = Physics.OverlapSphere (pos1, radius);
		collsPos2 = Physics.OverlapSphere (pos2, radius);
		for (int i = 0; i < collsPos1.Length; i++) {
			if (collsPos1 [i].gameObject.CompareTag ("ball")) {
				cf.force = new Vector3 (0.0f, 0.0f, 1.0f);
			}
		}

		for (int j = 0; j < collsPos1.Length; j++){
				if (collsPos2[j].gameObject.CompareTag("ball")) {
				cf.force = new Vector3 (0.0f, 0.0f, 1.0f);
			}
		}
					
		if (Physics.CheckSphere (pos1, radius)) {
			cf.force = new Vector3 (0.0f, 0.0f, 1.0f);
		} else if (Physics.CheckSphere (pos2, radius)) {
			cf.force = new Vector3 (0.0f, 0.0f, -1.0f);
		}*/


	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("door")) {
			newZ *= -5.0f;
			FixedUpdate();
		}
	}

	void FixedUpdate() {
		rb.AddForce(new Vector3(0.0f, 0.0f, newZ));
	}
}
