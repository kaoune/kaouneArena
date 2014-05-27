using UnityEngine;
using System.Collections;

public class shootBullets : MonoBehaviour 
{
	public PoolAble prefabPool;
	public Transform prefab;
	public Transform spawnPos;
	//public int speed;
	
	private Pool _pool;
	
	void Start()
	{
		_pool = new Pool(prefabPool, 500, 100);	
	}
	
	 void Update()
	{
        if (Input.GetMouseButton(1))
		{
			if(this.gameObject.name == "shootR")
			{
				PoolAble p = _pool.Get();
				p.transform.position = spawnPos.position;
				p.transform.rotation = transform.rotation;
			}
		}
		
		if (Input.GetMouseButton(0))
		{
			if(this.gameObject.name == "shootL")
			{
				PoolAble p = _pool.Get();
				p.transform.position = spawnPos.position;
				p.transform.rotation = transform.rotation;
			}
		}	
			//GameObject projectile = Instantiate(prefab, this.transform.position, this.transform.rotation) as GameObject;
			//projectile.rigidbody.AddForce(Vector3.forward * speed);
			//projectile.transform.Translate(Vector3.forward * speed * Time.deltaTime);			
	}
	
	void OnGUI(){
		GUILayout.Label(_pool.GetListLength().ToString());	
	}
}
