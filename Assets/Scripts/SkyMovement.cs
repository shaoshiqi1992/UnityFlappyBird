using UnityEngine;
using System.Collections;

public class SkyMovement : MonoBehaviour {

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
		float skySpeed = player.velocity.x * 0.9f;
		transform.position = transform.position + Vector3.right * skySpeed * Time.deltaTime;
	}

}
