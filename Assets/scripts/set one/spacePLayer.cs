using UnityEngine;
using System.Collections;

public class spacePLayer : MonoBehaviour {
	
	public float speed = 10.0F;
	public Transform player;
	public Transform bullet;

	// Update is called once per frame

    void Update() {
		
		Physics.gravity = new Vector3(0, 0.0F, 0);
    	
		 if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Instantiate(bullet, player.transform.localPosition, Quaternion.identity);
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow))
			player.transform.Translate(Vector3.right * speed);
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			player.transform.Translate(Vector3.left * speed);	
    }
}
