using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
	public virtual void Use() {Debug.Log("Use Item Mother Fucker !!!");}

	void OnTriggerEnter(Collider other) 
	{
		Bag bag = other.GetComponent<Bag>();
		if (bag == null)
			return;
		bag.AddItem(this);
		Destroy(gameObject);
		
	}
}