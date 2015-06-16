using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	GameObject[] num;
	// Use this for initialization
	void Start () {
		num = new GameObject[10];

		for (int i=0;i < 10;i++)
		{
			num [i] = transform.Find("b"+i).gameObject;
			num [i].SetActive(false);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
