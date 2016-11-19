using UnityEngine;
using System.Collections;

public class CollectableItem : Action {
	
	public override void ExecuteAction (GameObject other)
	{
		CollectedItemData cid = other.GetComponent<CollectedItemData>();

		if (cid != null && this.gameObject.activeSelf) {
			cid.addItem (this);
			this.gameObject.SetActive (false);
		}

	}

}
