﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRotate : MonoBehaviour {

    public float rotateSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
            transform.Rotate();
    }
}
