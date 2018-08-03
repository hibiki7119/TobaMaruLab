using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script00 : MonoBehaviour {
	//押された回数を格納する変数
	    private int counter = 0;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if　　（Input.GetButtonDown && ) {
            counter++;  //****追加
						if (counter <= 3) {//****追加
                Instantiate(this.ballPrefab);
            }
	}
}
