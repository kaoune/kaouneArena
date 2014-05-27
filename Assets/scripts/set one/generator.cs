using UnityEngine;
using System.Collections;

public class generator : MonoBehaviour {
	
	public Transform prefab, prefabBis;
	public float speed = 10.0f;
	public float delay;
	private float timeSinceLastSpaw;

	void Start () 
	{
	}
	
	void Update () 
	{
		this.timeSinceLastSpaw += Time.deltaTime;
		
		if(this.timeSinceLastSpaw >= this.delay)
		{
			Instantiate(prefab, new Vector3(0,20,0), Quaternion.identity);
			this.timeSinceLastSpaw = 0.0f;
		}
	}
}