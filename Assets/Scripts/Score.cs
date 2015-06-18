using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {

	public Text scoreText;
	// Use this for initialization
	static int score = 0;
	static int high = 0;

	static Score instance;

	static public void AddScore(){
		if (instance.bird.fail)
			return;
		score++;
		if (high < score){
			high = score;
		}
	}

	BirdMovement bird;

	void Start () {
		instance = this;
		GameObject player_go = GameObject.FindGameObjectWithTag("Player");
		if (player_go == null) {
			Debug.LogError("Bird lost");
		}
		bird = player_go.GetComponent<BirdMovement> ();
		score = 0;
		high = PlayerPrefs.GetInt ("high", 0);
	}
	void OnDestroy(){
		instance = null;
		PlayerPrefs.SetInt ("high", high);
	}
	// Update is called once per frame
	void Update () {
		scoreText.text = score + "/" + high;
	}
}
