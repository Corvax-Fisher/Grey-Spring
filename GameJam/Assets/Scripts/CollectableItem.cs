using UnityEngine;
using System.Collections;

public class CollectableItem : MonoBehaviour {
	
	void OnTriggerEnter(Collider other){
		CollectedItemData cid = other.gameObject.GetComponent<CollectedItemData>();

		if (cid != null && this.gameObject.activeSelf) {
			cid.addItem (this);
			this.gameObject.SetActive (false);
		}

	}

}
