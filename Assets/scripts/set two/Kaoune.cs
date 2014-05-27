using UnityEngine;
using System.Collections;

public class Kaoune : MonoBehaviour 
{
	void Awake ()
	{
		Debug.Log("Awake " + gameObject.name);	
	}

	void Start () 
	{
		Debug.Log("Start " + gameObject.name);
	}
	
	void OnEnable () 
	{
		Debug.Log("OnEnable " + gameObject.name);
	}
	
	void FixedUpdate () 
	{
		Debug.Log("FixedUpdate " + gameObject.name);
	}
	
	void Update () 
	{
		Debug.Log("Update " + gameObject.name);
	}
	
	void LateUpdate () 
	{
		Debug.Log("LateUpdate " + gameObject.name);
	}
	
	void onGUI () 
	{
		Debug.Log("onGUI " + gameObject.name);
	}
	
	void OnDisable () 
	{
		Debug.Log("OnDisable " + gameObject.name);
	}
	
}
