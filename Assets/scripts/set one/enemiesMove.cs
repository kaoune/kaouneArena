using UnityEngine;
using System.Collections;

public class enemiesMove : MonoBehaviour {
	
	public bool right;
	public bool left;
	public float speed;

	// Use this for initialization
	void Start () {
		right = true;
		left = false;
		speed = 100.0F;
	}
	
	// Update is called once per frame
	void Update () {

		if(right)
			this.transform.Translate(Vector3.right * speed * Time.deltaTime);
		
		if(left)
			this.transform.Translate(Vector3.left * speed * Time.deltaTime);
	}
	
	void OnTriggerEnter(Collider other) {
		if(other.name == "leftLimit")
		{
			this.transform.Translate(Vector3.down * 10);
			left = false;
			right = true;
			speed += 10;
		}
		if(other.name == "rightLimit")
		{
			this.transform.Translate(Vector3.down * 10);
			left = true;
			right = false;
			speed += 10;
		}
    }
}
