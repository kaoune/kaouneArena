using UnityEngine;
using System.Collections;

public class guiName : MonoBehaviour 
{
	
	public Camera cam;
	
	void OnGUI()
	{
		
		Vector3 screenPos = cam.WorldToScreenPoint(transform.position);
		screenPos.y = Screen.height - screenPos.y;
		Rect rect = new Rect(screenPos.x, screenPos.y, 50, 500);
		GUI.Label(rect, gameObject.name);
	}
}
