using UnityEngine;
using System.Collections;

public class hidePublic : MonoBehaviour 
{
	private float maxLife;
	public float MaxLife
	{
		get { return maxLife;}
		set { maxLife = Mathf.Max(0, value);}
	}

	private float life;
	public float Life
	{
		get { return life;}
		set { life = Mathf.Clamp(value, 0, MaxLife);}
	}
	
	public void Die()
	{
		life = 0;	
	}
	
	public void ImAlive()
	{
		life = maxLife;
	}
	
	void Update()
	{
		if(Life <= 0)
		{
			renderer.material.color = Color.red;
		}
		
		if(Life > 0 && Life < (maxLife/2))
		{
			renderer.material.color = Color.yellow;
		}
		
		if(Life > (MaxLife/2))
		{
			renderer.material.color = Color.green;
		}
	}
}
