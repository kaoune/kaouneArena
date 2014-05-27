using UnityEngine;
using System.Collections;

public class Cycle : MonoBehaviour {
	
	public float t;
	
	void Awake() 
	{
		//t = Time.time;
		 t = 0;
	}
	
	void Update() 
	{
		Debug.Log(gameObject.name + " " + t);
	}
}
