using UnityEngine;
using System.Collections;

public class BackgroundLoop : MonoBehaviour {

	int backgroundNum = 6;
	float pipeMin = 1.8f;
	float pipeMax = 3.28f;
	void Start(){
		GameObject[] pipes = GameObject.FindGameObjectsWithTag("Pipe");
		foreach (GameObject pipe in pipes) {
			Vector3 position = pipe.transform.position;
			position.y = Random.Range(pipeMin,pipeMax);
			pipe.transform.position = position;
		}
	}

	void OnTriggerEnter2D(Collider2D collider){
		//Debug.Log ("Triggered" + collider.name);

		float backgroundWidth = ((BoxCollider2D)collider).size.x;

		Vector3 position = collider.transform.position;

		position.x += backgroundWidth * backgroundNum - backgroundWidth/2f;

		if (collider.tag == "Pipe") {
			position.y = Random.Range(pipeMin,pipeMax);
		}

		collider.transform.position = position;


	}
}
