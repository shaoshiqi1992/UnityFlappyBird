using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour {
	//Vector3 velocity = Vector3.zero;
	//public Vector3 gravity;
	public float flapForce;
	public float forwardspeed;
	private float coolDown;
	//public float maxspeed;
	bool flap = false;
	public bool fail = false;
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator> ();
		//Debug.Log (animator);
		GetComponent<Rigidbody2D> ().AddForce (Vector2.right*forwardspeed);
	}
	

	// Update is called once per frame
	void Update () {
		if (fail) {
			coolDown -= Time.deltaTime;
			if(coolDown <= 0 && Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0)){
				Application.LoadLevel(Application.loadedLevel);
			}
		} else {
			if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0)) {
				flap = true;
				
			}
		}
	}

	void FixedUpdate(){
		if (fail) {
			return ;
		}

		if (flap == true) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * flapForce);
			animator.SetTrigger("DoFlap");
			flap = false;
		}

		if (GetComponent<Rigidbody2D> ().velocity.y > 0) {
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}else{
			float angle = Mathf.Lerp(0,-90,-GetComponent<Rigidbody2D>().velocity.y/3f);
			transform.rotation = Quaternion.Euler (0, 0, angle);
		}

	}
	void OnCollisionEnter2D(Collision2D collision){
		animator.SetTrigger("Fail");
		fail = true;
		coolDown = 0.5f;
	}
}
