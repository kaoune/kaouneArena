using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pool : object 
{
	private List<PoolAble> _list;
	private int _extend;
	private PoolAble _objectBase;
	
	public Pool(PoolAble obj, int nbObj, int extend)
	{
		_list = new List<PoolAble>();
		_extend = (extend <= 0 ? 1 : extend);
		_objectBase = obj;
		
		AddObject(nbObj);
	}
	
	public PoolAble Get()
	{
		for(int i = 0; i < _list.Count; i++)
		{
			if (_list[i].CanUse())
			{
				_list[i].OnStartUse();
				return _list[i];
			}
		}
		
		AddObject(_extend);
		return Get();
	}
	
	void AddObject(int nb)
	{
		for (int i = 0; i < nb; i++)
		{
			GameObject o = GameObject.Instantiate(_objectBase.gameObject) as GameObject;
			PoolAble p = o.GetComponent<PoolAble>();
			p.OnRelease();
			_list.Add(p);
		}
	}
	
	public int GetListLength(){
		return _list.Count;	
	}
}
