using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class MultiConditionAction : Action {


	public List<CollectableItem> collectedItems;


	public override void ExecuteAction (GameObject other)
	{
		CollectedItemData ci = other.GetComponent<CollectedItemData> ();

		Debug.Log ("MULTI Möp");

		if (ci != null) {
			if (ci.hasItems (collectedItems)) {
				Debug.Log ("Has Items");
				this.ExecuteCollectedItemsAction (other);
			}
		}
	}

	public abstract void ExecuteCollectedItemsAction (GameObject other);
}
