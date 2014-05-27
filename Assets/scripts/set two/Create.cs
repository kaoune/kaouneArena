using UnityEngine;
using System.Collections;

public class Create : MonoBehaviour 
{

	public GameObject p;
	public int nb;
	
	IEnumerator Start () 
	{
		/*
		for (int i = 0; i < nb; i++)
		{
			Instantiate(p);
			yield return null;
		}
		*/
		
		for (int i = 0; i < nb; i++)
		{
			GameObject o = Instantiate(p) as GameObject;
			Cycle c = o.GetComponent<Cycle>();
			c.t = i;
			yield return null;
		}
	}
}
