using UnityEngine;
using System.Collections;

public class spaceEnemies : MonoBehaviour {
	
	public Transform enemy1;
	public Transform enemy2;

	void Start () {
		  
	}
	
	void Update () {
		Physics.gravity = new Vector3(0, 0.0F, 0);
		this.transform.parent = this.transform;
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player")
		{
			Destroy(other.gameObject);
			Debug.Log("GAME OVER MOTHER FUCKER !!!");
		}
    }
}
