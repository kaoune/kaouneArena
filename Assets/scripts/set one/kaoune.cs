﻿using UnityEngine;
using System.Collections;

public class kaoune : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{	
		transform.Translate(Vector3.right * Time.deltaTime * 1.0f, Space.World);
		transform.Rotate(Vector3.forward * Time.deltaTime * 180.0f);
	}
}