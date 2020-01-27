using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddObject : MonoBehaviour
{
    private Inventory inventory;
	private void Start(){
		inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
	}
	
	public void addObject(GameObject item){
		for(int i = 0; i < inventory.objSlots.Length; i++){
			if(inventory.isFull[i] == false){
				inventory.isFull[i] = true;
				inventory.objSlots[i] = item;
				Instantiate(item, inventory.slots[i].transform, false);
				break;
			}
		}
	}
}
