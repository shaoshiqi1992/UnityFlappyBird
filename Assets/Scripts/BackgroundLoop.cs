using UnityEngine;
using System.Collections;

public class BackgroundLoop : MonoBehaviour {

	int backgroundNum = 6;

	void OnTriggerEnter2D(Collider2D collider){
		//Debug.Log ("Triggered" + collider.name);

		float backgroundWidth = ((BoxCollider2D)collider).size.x;

		Vector3 position = collider.transform.position;

		position.x += backgroundWidth * backgroundNum - backgroundWidth/2f;

		collider.transform.position = position;
	}
}
