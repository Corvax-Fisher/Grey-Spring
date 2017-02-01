using UnityEngine;
using System.Collections;

public class Teleporter : Action {

	public TeleportTarget target;

  new void Start()
  {
    base.Start();
    ColorCondition cc = GetComponent<ColorCondition>();
    if(cc != null && target != null)
    {
      target.gameObject.GetComponent<Renderer>().material.color = cc.color.color;
    }
  }

	public override void ExecuteAction (GameObject other)
	{
		TeleportController controller = other.GetComponent<TeleportController> ();
		controller.teleportTo (target.getLocation());
	}


}
