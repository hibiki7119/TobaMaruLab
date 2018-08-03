using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreText : MonoBehaviour {
	//点数を格納する変数
	    public int score = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = "点数" + score.toString() + "点";
	}
}
