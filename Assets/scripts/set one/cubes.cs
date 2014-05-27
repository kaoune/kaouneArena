using UnityEngine;
using System.Collections;

public class cubes : MonoBehaviour {


	// Use this for initialization
	void Start () {
		int i = 0;
		int k = 0;
				
		while(i < 10)
		{
			GameObject cubes = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cubes.transform.Translate(k, 0, 0);
			k+=2;
			i++;
		}
		
	//	Instantiate(GameObject cube, new Vector3(0, 0, 0), Quaternion.identity) as GameObject);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}