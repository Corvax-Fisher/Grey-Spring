using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollectedItemData : MonoBehaviour {

	public List<CollectableItem> collectedItems = new List<CollectableItem>();


	public bool hasItems(List<CollectableItem> items){
		int count = 0;


		foreach(CollectableItem item in collectedItems){

			if (items.Contains (item)) {
				Debug.Log(count++);
			}
		}
			
		return count == items.Count;
	}

	public void addItem(CollectableItem item){
		collectedItems.Add (item);
		printData ();
	}

	public void printData(){
	
		Debug.Log (collectedItems.Count);
	
	}
}
