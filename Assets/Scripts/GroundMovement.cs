using UnityEngine;
using System.Collections;

public class GroundMovement : MonoBehaviour {

	//public float speed;
	
	//void FixedUpdate(){
	//	Vector3 position = transform.position;
	//	position.x += speed * Time.deltaTime;
	//	transform.position = position;
	//}
	Rigidbody2D player;
	// Use this for initialization
	void Start () {
		GameObject playerstart = GameObject.FindGameObjectWithTag("Player");
		if (playerstart == null) {
			Debug.LogError("Cant find the bird");
			return;
		}
		player = playerstart.GetComponent<Rigidbody2D>();
		
	}
	
	
	void FixedUpdate(){
		float groundSpeed = player.velocity.x * 0.9f;
		transform.position = transform.position + Vector3.right * groundSpeed * Time.deltaTime;
	}
}
