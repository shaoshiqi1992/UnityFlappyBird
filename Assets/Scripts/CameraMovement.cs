using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	float offsetx;
	Transform player;
	// Use this for initialization
	void Start () {
		GameObject playerstart = GameObject.FindGameObjectWithTag("Player");
		if (playerstart == null) {
			Debug.LogError("Cant find the bird");
			return;
		}
		player = playerstart.transform;
		offsetx = this.transform.position.x - player.position.x;

	}

	
	// Update is called once per frame
	void Update () {
		if(player != null){
			Vector3 position = transform.position;
			position.x = player.position.x + offsetx;
			transform.position = position ;
		}
	}
}
