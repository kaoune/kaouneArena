using UnityEngine;
using System.Collections.Generic;

public class scoreManager : MonoBehaviour 
{


/**********************************************************************
	private int score;
	
	public void Awake ()
	{
		score = 0;
	}
	
	public void Start () 
	{
		
	}
	
	public int Add(int val)
	{
		if(val>=0)
		{	
			score += val;
		}
		return score;
	}
**********************************************************************/
	
/*	
	public string[] pName;
	private int[] score;
	
	public void Awake ()
	{
		score = new int[pName.Length];
		DontDestroyOnLoad(this.gameObject);
	}
	private int GetIndex(string name)
	{
		for(int i = 0; i<score.Length; i++)
			if(pName[i]
	}

	public int GetScore(int index)
	{
		if (index < 0 || index >= score.Length)
			return 0;
		return score[index];
	}
	public void Start () 
	{
		
	}
	public bool Add(string name, int val)
	{
		for(int i= 0; i<score.Length; i++)
		{
			if (pName[i] == name)
			{
				return Add(i, val);
			}
		}
		return false;
	}
	public bool Add(int index, int val)
	{
		if (index < 0 || index >= score.Length)
			return false;
		if (val < 0)
			return false;
		this.score[index] += val;
		return true;
	}

	
	
	private Dictionary <string, Profile> profiles;
	
	public void Awake()
	{
		this.profiles = new Dictionary<string, Profile>();
		DontDestroyOnLoad(this.gameObject);
	}
	public void AddPlayer(string name)
	{
		if(this.profiles.ContainsKey(name))
			return false;
		this.profiles[name] = new Profile(name);
		return true;
	}
	public Profile GetPlayer(string name)
	{
		if (this.profiles.ContainsKey(name))
			return this.profiles[name];
		return null;
	}
	public Profile[]GetAllPlayer()
	{
		string[] p = new string[this.profiles.Count];
		int i = 0;
		foreach(KeyValuePair<string, Profile> v in this.profiles)
		{
			p[i++] = v.Key;
		}
		return p;
	}
	*/
}
