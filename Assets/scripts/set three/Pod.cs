using UnityEngine;
using System.Collections;

public class Pod : MonoBehaviour 
{
    public float sens;
    public Transform[] raycastPosition;
    public float rayDist;
    public float maxXDif;
    public float stab;
	public float getSens = 0;

    [HideInInspector]
    public bool isGrounded = false;

    private Vector3 orientation = Vector3.zero;
	
    void Update()
    {
		if(this.isGrounded)
		{
			 Physics.gravity = new Vector3(0, -9.0F, 0);	
		}
		if(!this.isGrounded)
		{
			 Physics.gravity = new Vector3(0, -55.0F, -35.0f);	
		}
		//float direction = getSens;
        float direction = Input.GetAxis("Horizontal");
        this.orientation.y += sens * direction * Time.deltaTime;
        this.orientation.z =- direction * 25;
        Vector3 p1, p2;
        if (Raycast(0, out p1) && Raycast(1, out p2))
        {
            Vector3 vec = p2 - p1;
            vec.Normalize();
            float newX = 90 - Vector3.Angle(vec, Vector3.up);
            this.orientation.x = Mathf.Clamp(newX,
                this.orientation.x - maxXDif * Time.deltaTime,
                this.orientation.x + maxXDif * Time.deltaTime);
            this.isGrounded = true;
        }
        else if (this.orientation.x != 0)
        {
            float dir = this.orientation.x / Mathf.Abs(this.orientation.x);
            this.orientation.x -= dir * stab * Time.deltaTime;
            this.isGrounded = false ;
        }
        this.transform.rotation = Quaternion.Euler(this.orientation);
    }

    bool Raycast(int index, out Vector3 pos)
    {
        pos = Vector3.zero;
        Ray ray = new Ray(raycastPosition[index].position, -Vector3.up);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayDist))
        {
            pos = hit.point;
            return true;
        }
        return false;
    }
}
