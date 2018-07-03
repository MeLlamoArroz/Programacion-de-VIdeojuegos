using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkandShoot : MonoBehaviour {

	public GameObject pokeball;
	public float shootingSpeed = 10;
	public float speed;

	void Start () {
		
	}

	void Update () {
		//transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;

		if (Input.GetButtonDown ("Fire1")) {
		//if (Input.GetKeyDown ("joystick button 0"))
		//{
			GameObject pokego = Instantiate (pokeball);
			//pokego.transform.position = transform.position;
			pokego.transform.position = new Vector3 (transform.position.x, transform.position.y + 1.0f ,transform.position.z);
			Rigidbody rb = pokego.GetComponent<Rigidbody> ();
			Camera cam = GetComponentInChildren<Camera> ();
			rb.velocity = cam.transform.rotation * Vector3.forward * shootingSpeed;
		}
		//}
	}
}
