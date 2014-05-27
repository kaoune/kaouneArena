using UnityEngine;
using System.Collections;

public class sort_array : MonoBehaviour {
	
	
	float x;

	float[] array;
		
	// Use this for initialization
	void Start () 
	{
		
		array = new float[10];
		
		int i = 0;
		while(i < array.Length)
		{
			x = Random.value*100;
			array[i] = x;
			print(array[i]);
			
			i++;
		}
		
	}
	/*
	int[] GenArray(int size)
	{
		int ret = new int[size];
		for (int i = 0; i<size; i++)
			ret[i] = (int)(Random.value * 100);
		return ret;
	}
	
	void DisplayArray()
	{
		
	}
	
	void SortArray(int[] array)
	{
		bool sorted;
		do
		{
			sorted = true;
			for (int i = 0 ; i < array.Length -1; i++)
			{
				if (array[i] > array[i +1])
				{
					Swap(array, i, i + 1);
					sorted = false;
				}
			}
		} while (sorted = false);
	}
	
	void Swap(int[] array, int index1, int index2)
	{
		int tmp = array[index1];
		array[index1] = array[index2];
		array[index2] = tmp;
	}
	*/
	// Update is called once per frame
	void Update () 
	{
		
	}
}
