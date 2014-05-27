using UnityEngine;
using System.Collections;

public class bullets : MonoBehaviour {
	
	public float speed = 10.0F;
	public float time;

	// Use this for initialization
	void OnEnable () 
	{	
		Invoke("Die",time);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		//this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
		this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
		//this.rigidbody.AddForce(Vector3.forward * speed);
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag != "Bullets")
		{
			//Destroy(other.gameObject);
			//Destroy(this.gameObject);
			PoolAble p = GetComponent<PoolAble>();
			p.OnRelease();
		}
		
    }
	
	void Die()
	{
		PoolAble p = GetComponent<PoolAble>();
		p.OnRelease();
	}
}
