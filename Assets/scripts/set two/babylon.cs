using UnityEngine;
using System.Collections;

public class babylon : MonoBehaviour {
	
	void OnHit()
	{
		Debug.Log("babylone");
		this.transform.renderer.material.color = Color.green;
	}
}
