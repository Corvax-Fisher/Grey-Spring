using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollectableCondition : ICondition {

	public List<CollectableItem> collectedItems;

	void Start(){
		
	}

	public override bool isConditionFullfilled (GameObject gameObject){
		CollectedItemData ci = gameObject.GetComponent<CollectedItemData> ();
		return ci != null && ci.hasItems (collectedItems);
	}

}
