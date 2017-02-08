﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Horizontal") > 0.2) {
			transform.Rotate (0, 0, -1);
		}

		if (Input.GetAxis ("Horizontal") < -0.2) {
			transform.Rotate (0, 0, 1);
		}  

		if (Input.GetAxis ("Vertical") > 0.2) {
			transform.Rotate ( 1, 0, 0);
		}

		if (Input.GetAxis ("Vertical") < -0.2) {
			transform.Rotate (-1, 0, 0); 
		}
	}
}
