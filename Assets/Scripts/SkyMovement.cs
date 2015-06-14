using UnityEngine;
using System.Collections;

public class SkyMovement : MonoBehaviour {

		public float speed;
		
		void FixedUpdate(){
			Vector3 position = transform.position;
			position.x += speed * Time.deltaTime;
			transform.position = position;
			
		}

}
