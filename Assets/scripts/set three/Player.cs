using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public int tour;
	public float startTime = 0;
	public float timer = 0;
	public float finalTime;
	
	public string nbTour = "Tour : ";
	public string temps = "Time : ";
	
	public bool raceStarted = false;
	public bool checkpoint1 = false;
	public bool checkpoint2 = false;
	public bool checkpoint3 = false;
	
	// Use this for initialization
	void Start ()
	{
		/*
	 	if (Network.isClient || Network.isServer)
			player =  Network.Instantiate(prefab, transform.position, transform.rotation, 0) as GameObject;
        else
        	player = GameObject.Instantiate(prefab, transform.position, transform.rotation) as GameObject;
               
		cam.target = player.transform;
        physic.pod = player.GetComponent<Pod>();
        */
	}
	
	void OnTriggerEnter(Collider other) 
	{
		if(other.tag == "start")
		{
			if(!this.checkpoint1 && !this.checkpoint2 && !this.checkpoint3 && !this.raceStarted)
			{       
				this.startTime = Time.time;
				this.tour += 1 ;
				this.raceStarted = true;	
			}
			
			if(this.checkpoint1 && this.checkpoint2 && this.checkpoint3 && this.raceStarted)
			{	
				this.tour += 1 ;
				this.checkpoint1 = false;
				this.checkpoint2 = false;
				this.checkpoint3 = false;			
			}
		}
		if(other.tag == "check1")
		{
			if(this.checkpoint1 == false && this.raceStarted == true)
			{
				this.checkpoint1 = true;
			}
		}
		if(other.tag == "check2")
		{
			if(this.checkpoint1 == true && this.checkpoint2 == false)
			{
				this.checkpoint2 = true;
			}
		}
		if(other.tag == "check3")
		{
			if(this.checkpoint2 == true && this.checkpoint3 == false)
			{
				this.checkpoint3 = true;
			}
		}
    }
	
	void OnGUI() 
	{
		if(this.raceStarted)
		{			
			if (networkView.isMine == true)
			{
				GUI.TextField(new Rect(10, 10, 100, 20), nbTour+this.tour, 25);
				GUI.TextField(new Rect(10, 35, 100, 20), temps+this.timer, 25);
			}
		} 
    }
	
	// Update is called once per frame
	void Update () 
	{
		if(this.raceStarted)
			this.timer = Time.time-startTime;
		
			if(this.tour > 3)
			{
				this.tour = 0;
				this.raceStarted = false;
				this.checkpoint1 = false;
				this.checkpoint2 = false;
				this.checkpoint3 = false;
			
				finalTime = timer;	
				Debug.Log(finalTime);
			}
	}
	
}
