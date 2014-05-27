using UnityEngine;
using System.Collections;

public class scoreTest : MonoBehaviour 
{
	public scoreManager score;
	
	void Start () 
	{
		
	}
	
	void Update () 
	{
/*		if(Input.GetKeyDown(KeyCode.A))
			scoreManager.Add(0,1);
		if(Input.GetKeyDown(KeyCode.B))
			scoreManager.Add(1,1);
			*/
	}
	void OnGUI() 
	{
		//GUILayout.Label(score.GetName(0) + " : " + score.GetScore(0).ToString());
		//GUILayout.Label(score.GetName(1) + " : " + score.GetScore(1).ToString());
    }
}
