using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public float speed = 20.0f;
	public int lifeTime = 0;
	
	void Awake() 
	{
		//lifeTime = Time.deltaTime;
	}
	
	void Update () 
	{
		//Debug.Log(lifeTime);
		
		lifeTime += 1;
		
		transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
		
		if(lifeTime > 100)
		{
			Destroy(this.gameObject);
		}
	}
	
	
	void OnTriggerEnter(Collider other) 
	{
		//Destroy(other.gameObject);
		Destroy(this.gameObject);
		Debug.Log(other.name);
    }

}
