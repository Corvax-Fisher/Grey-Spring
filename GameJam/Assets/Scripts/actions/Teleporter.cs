using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

	public TeleportTarget target;

	void OnTriggerEnter(Collider other){
	
		TeleportController controller = other.gameObject.GetComponent<TeleportController> ();
		controller.teleportTo (target.getLocation());
	}
}
