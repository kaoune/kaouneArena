using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour 
{
	
	public startRace startRaceScript;
	
	void OnTriggerEnter(Collider other) 
	{	
       	if(other.tag == "Player")
		{
			if(this.gameObject.tag == "check1")
			{
				if(startRaceScript.checkpoint1 == false && startRaceScript.raceStarted == true)
				{
					startRaceScript.checkpoint1 = true;
				}
			}
			if(this.gameObject.tag == "check2")
			{
				if(startRaceScript.checkpoint1 == true && startRaceScript.checkpoint2 == false)
				{
					startRaceScript.checkpoint2 = true;
				}
			}
			if(this.gameObject.tag == "check3")
			{
				if(startRaceScript.checkpoint2 == true && startRaceScript.checkpoint3 == false)
				{
					startRaceScript.checkpoint3 = true;
				}
			}
		}
	}
}
