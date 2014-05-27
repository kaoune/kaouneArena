using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PodPhysic : MonoBehaviour 
{
    public Pod pod;
    public Vector3 offset;
    public float acc;
	private bool accOk = false;
	public float getSens = 0;
	private bool leftButton = false;
	private bool rightButton = false;

    void Update()
    {
        this.pod.transform.position = this.transform.position + offset;
		if(rightButton)
		{
			if(pod.getSens<1)
 				pod.getSens +=0.10f;
		}
		if(leftButton)
		{
			if(pod.getSens>-1)
				pod.getSens -=0.10f;
		}
		if(!rightButton && !leftButton)
		{
			if(pod.getSens< -0.1f)
				pod.getSens += 0.10f;
			else if(pod.getSens > 0.1f)
				pod.getSens -= 0.10f;
		}
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) || accOk /*&& pod.isGrounded*/)
        {
            rigidbody.AddForce(this.pod.transform.forward * acc);
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawLine(this.transform.position, this.transform.position + rigidbody.velocity);
    }
	void accel()
	{
		accOk = true;
	}
	void notAccel()
	{
		accOk = false;	
	}
		void pressRight()
	{
		rightButton = true;
	}
	void pressLeft()
	{
		leftButton = true;	
	}
	void notRight()
	{
		rightButton = false;
	}
	void notLeft()
	{
		leftButton = false;
	}
}
