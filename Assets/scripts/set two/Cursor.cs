using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour 
{

	public Texture2D texture;
 
    //private int cursorWidth = 32;
    //private int cursorHeight = 32;
 	
	public bool centerTexture, showNatifCursor;
	public int guiDepth;
	
	
    void Start()
    {
        //Screen.showCursor = false;
		
		Screen.showCursor = showNatifCursor;
    }
 
    void OnGUI()
    {
		GUI.depth = this.guiDepth;
		
		Vector3 mouseScreenPosition = Input.mousePosition;
		mouseScreenPosition.y = (mouseScreenPosition.y - Screen.height)* -1;
		
		if (this.centerTexture)
		{
			mouseScreenPosition.x -= (texture.width/20) / 2;
			mouseScreenPosition.y -= (texture.height/20) / 2;
		}
		
		Rect textureRect = new Rect(mouseScreenPosition.x, mouseScreenPosition.y, this.texture.width/20, this.texture.height/20);
		GUI.DrawTexture(textureRect, this.texture);
		
		//GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), cursorImage);
    }
	
}