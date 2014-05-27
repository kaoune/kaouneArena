using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour 
{
	public GameObject p;
	public GameObject g;
	
	public float speed = 10.0F;
	public float shootSpeed = 1.0f;
    public float jumpSpeed = 8.0F;
	public float gravity = 10.0F;
	public bool shootOn = false;
	
	private Vector3 moveDirection = Vector3.zero;
	
	void Awake () 
	{
	
	}
	
	void Update () 
	{	
		Move();
		Rotate ();
		
		if(Input.GetMouseButtonDown(0))
		{
			shootOn = true;	
		}
		
		else if(Input.GetMouseButtonUp(0))
		{
			shootOn = false;	
		}
		
		Shoot();
		
		
		
		
		/*
		if(Input.GetMouseButtonDown(0))
		{
			Shoot();	
		}
		*/
	}
	
	void Rotate ()
	{
		Vector3 position = Input.mousePosition;
		position.z = Camera.main.transform.position.y - transform.position.y;
		position = Camera.main.ScreenToWorldPoint(position);
		transform.LookAt(position);
	}
	
	void Move()
	{
		CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded) 
		{
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed; 
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
	}
	
	void Shoot()
	{
		if(shootOn)
		{
			GameObject o = Instantiate(p, g.transform.position , g.transform.rotation) as GameObject;
		}
	}
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Bullet")
		{
			//Destroy(other.gameObject);
			Debug.Log("GAME OVER MOTHER FUCKER !!!");
		}
    }
}
