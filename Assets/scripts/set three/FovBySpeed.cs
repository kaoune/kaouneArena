using UnityEngine;
using System.Collections;

public class FovBySpeed : MonoBehaviour 
{
	
	public Rigidbody r;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		camera.fieldOfView = 50 + (r.velocity.magnitude * 0.5f);
	}
}
