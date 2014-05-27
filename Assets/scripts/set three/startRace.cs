using UnityEngine;
using System.Collections;

public class startRace : MonoBehaviour 
{
	public int tour;
	public float startTime = 0;
	public float timer = 0;
	
	public string nbTour = "Tour : ";
	public string temps = "Time : ";
	
	public bool raceStarted = false;
	public bool checkpoint1 = false;
	public bool checkpoint2 = false;
	public bool checkpoint3 = false;
	
	void OnTriggerEnter(Collider other) 
	{
		if(other.tag == "start")
		{
			if(tour > 3)
			{
				tour = 0;
				raceStarted = false;
				checkpoint1 = false;
				checkpoint2 = false;
				checkpoint3 = false;
			}
			if(!checkpoint1 && !checkpoint2 && !checkpoint3 && !raceStarted)
			{       
				startTime = Time.time;
				tour += 1 ;
				raceStarted = true;	
			}
			
			if(checkpoint1 && checkpoint2 && checkpoint3 && raceStarted)
			{	
				tour += 1 ;
				checkpoint1 = false;
				checkpoint2 = false;
				checkpoint3 = false;			
			}
		}
    }
	
	void OnGUI() 
	{
		if(raceStarted)
		{
			GUI.TextField(new Rect(10, 10, 100, 20), nbTour+tour, 25);
			GUI.TextField(new Rect(10, 35, 100, 20), temps+timer, 25);
		}
        
    }
	
	void Update () 
	{
		if(raceStarted)
			timer = Time.time-startTime;		
	}
}
