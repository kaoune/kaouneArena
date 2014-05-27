using UnityEngine;
using System.Collections;

public class rayshoot : MonoBehaviour {
	
	public Camera cam;
	
	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Ray r = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast (r, out hit))
			{
				//hit.transform.renderer.material.color = Color.green;
				hit.transform.SendMessage("OnHit", SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
