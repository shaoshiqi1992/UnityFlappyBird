using UnityEngine;
using System.Collections;

public class GroundMovement : MonoBehaviour {

		public float speed;
		
		void FixedUpdate(){
		Vector3 position = transform.position;
		position.x += speed * Time.deltaTime;
		transform.position = position;
	}

}
