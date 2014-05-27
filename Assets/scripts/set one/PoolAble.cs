using UnityEngine;
using System.Collections;

public class PoolAble : MonoBehaviour 
{
	private bool _canUse = true;
	
	public bool CanUse()
	{
		return _canUse;
	}
	
	public void OnStartUse()
	{
		gameObject.SetActive(true);
		_canUse = false;
	}
	
	public void OnRelease()
	{
		gameObject.SetActive(false);
		_canUse = true;
	}
}
