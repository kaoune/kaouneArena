using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveChar : MonoBehaviour {
 
	 delegate void Handle();
	 
	 private Dictionary<CollisionFlags, Handle> myUpdate;
	 
	 private CharacterController c;

 // Use this for initialization
	 void Awake () 
	{
	  	c = GetComponent<CharacterController>();
	 	myUpdate=new Dictionary<CollisionFlags, Handle>();
		myUpdate[CollisionFlags.None]=AirUpdate;
		myUpdate[CollisionFlags.Sides]=WallUpdate;
	}
 
	 void Update () 
	{
		  /*if(c.collisionFlags == CollisionFlags.None)
		   AirUpdate();
		  else if(c.collisionFlags == CollisionFlags.Sides)
		   WallUpdate();
		  else
		   GroundUpdate();*/
			
		  if(myUpdate.ContainsKey(c.collisionFlags))
		   myUpdate[c.collisionFlags]();
		  else
		   GroundUpdate();
	}
 
	void GroundUpdate(){}
	void AirUpdate(){}
	void WallUpdate(){}
}