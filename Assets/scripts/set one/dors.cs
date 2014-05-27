using UnityEngine;
using System.Collections;

public class dors : MonoBehaviour {
	
	public GameObject Dor;
	public GameObject dorOpen;
	public GameObject dorClose;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnTriggerEnter(Collider other) 
	{
        if(other.tag == "Player")
		{
			Dor.transform.Translate(0, 8, 0);
		}
    }
}
