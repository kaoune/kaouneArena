using UnityEngine;
using System.Collections;

public class noGravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Physics.gravity = new Vector3(0, 0.0F, 0);
		//this.transform.Translate(Vector3.up * 10);
	}
}
