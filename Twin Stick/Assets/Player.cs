﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		print("Hor : " + CrossPlatformInputManager.GetAxis("Horizontal"));
		print("Ver : " + CrossPlatformInputManager.GetAxis("Vertical"));
	}
}
