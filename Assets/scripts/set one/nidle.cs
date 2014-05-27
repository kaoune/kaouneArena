using UnityEngine;
using System.Collections;

public class nidle : MonoBehaviour {
	
	public float speed = 50.0f;
	// Use this for initialization
	void Start () 
	{
		GameObject cubes = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cubes.transform.parent = this.transform;
		cubes.transform.localPosition = new Vector3(0,1.0f,0);
		cubes.transform.localScale = new Vector3(1.0f,2.0f,0.5f);
		    
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.transform.Rotate(Vector3.forward * speed * Time.deltaTime);
	}
}
