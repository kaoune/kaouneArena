using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using System.Object;
//using System.Collections.Queue;

public class Bag : MonoBehaviour {
		
	//private List<Item> list;
	private Queue<Item> list;
	
	// Use this for initialization
	void Start () 
	{
		//list = new List<Item>();
		list = new Queue<Item>();
		/*
		AddItem(new Life());
		AddItem(new Mana());
		AddItem(new Life());
		UseItem();
		UseItem();
		UseItem();
		*/
	}
		
	public void AddItem(Item item)
	{
		//list.Add(item);
		list.Enqueue(item);
	}
	
	public void UseItem()
	{
		//Item i = list[0];
		//list.RemoveAt(0);
		//return i;
		
		if(list.Count == 0)
			return;
		
		Item i = list.Dequeue();
		i.Use ();
	}
	
	void DisplayItems()
	{
		foreach (Item i in list)
			Debug.Log(i);
	}

	void Update () 
	{
		if (Input.GetKey("u"))
		{
			UseItem();
		}
	}
}
