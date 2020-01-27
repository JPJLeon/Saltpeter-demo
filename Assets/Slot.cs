using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventory inventory;
	public int i;
	
	private void Start(){
		inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
	}
	
	public void DestroyItem(){
		foreach(Transform child in transform){
			GameObject.Destroy(child.gameObject);
			inventory.isFull[i-1] = false;
			
		}
	}
}
