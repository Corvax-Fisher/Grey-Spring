using UnityEngine;
using System.Collections;

public class Teleporter : Action {

	public TeleportTarget target;

	public override void ExecuteAction (GameObject other)
	{
		TeleportController controller = other.GetComponent<TeleportController> ();
		controller.teleportTo (target.getLocation());
	}


}
