using UnityEngine;
using System.Collections;

public class miltiSphere : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () 
	{
		
		GameObject spheres = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		spheres.transform.parent = this.transform;
		spheres.transform.localPosition = new Vector3(0,0,0);
				
		spheres = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		spheres.transform.parent = this.transform;
		spheres.transform.localPosition = new Vector3(5,0,0);
		
		spheres = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		spheres.transform.parent = this.transform;
		spheres.transform.localPosition = new Vector3(5,5,0);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
