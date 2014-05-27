using UnityEngine;
using System.Collections;

public class the_finger : MonoBehaviour {
	float speed = 20.0f;
	public KeyCode pos, neg;
	// Use this for initialization
	void Start () 
	{
	
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(pos))
			this.transform.Rotate(Vector3.forward * speed * Time.deltaTime);
		if (Input.GetKey(neg))
			this.transform.Rotate(Vector3.forward * (-speed) * Time.deltaTime);		
	}
}


/*

	transform.transform.Translate(Vector3.right * Time.deltaTime * 1f);
	transfom.Rotate(vector3.forward * Time.deltaTime * 180.0f);


*/
