using UnityEngine;
using System.Collections;

public class PlayerNetwork : MonoBehaviour 
{
	   // public SmoothFollow cam;
	    public PodPhysic physic;
	    public GameObject prefab;
	
	    private GameObject player;

       // Use this for initialization
       void Start () {
               if (Network.isClient || Network.isServer)
                       this.player =  Network.Instantiate(this.prefab, this.transform.position, this.transform.rotation, 0) as GameObject;
               else
                       this.player = GameObject.Instantiate(this.prefab, this.transform.position, this.transform.rotation) as GameObject;
              
			//   this.cam.target = this.player.transform;
               this.physic.pod = this.player.GetComponent<Pod>();
       }
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}