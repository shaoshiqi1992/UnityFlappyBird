using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour {
	Vector3 velocity = Vector3.zero;
	public Vector3 gravity;
	public Vector3 flapvelocity;
	public float forwardspeed;
	public float maxspeed;
	bool flap = false;

	// Use this for initialization
	void Start () {
	
	}
	

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0)) {
			flap = true;


		}
	}

	void FixedUpdate(){
		velocity.x = forwardspeed;
		velocity += gravity * Time.deltaTime;
		if (flap) {
			flap =false;
			if(velocity.y<0){
				velocity.y = 0;
			}
			velocity += flapvelocity;
		}
		velocity = Vector3.ClampMagnitude (velocity, maxspeed);
		transform.position += velocity * Time.deltaTime;
		float angle = 0;
		if (velocity.y < 0) {
			angle = Mathf.LerpAngle(0,-90,-velocity.y/maxspeed);
		}
		transform.rotation = Quaternion.Euler (0, 0, angle);
	}
}
