using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barco : MonoBehaviour {

	Rigidbody rb;
	float dirX, positionz;
	public float speed = 20f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
        positionz = 57;
    }
	
	// Update is called once per frame
	void Update () {
		dirX = Input.acceleration.x * speed;
		transform.position += new Vector3(Input.acceleration.x * Time.deltaTime * speed,0.81f,speed);
        transform.rotation = Quaternion.identity;
    }

	void FixedUpdate()
	{
		rb.velocity = new Vector2 (dirX, 0f);
	}

}
