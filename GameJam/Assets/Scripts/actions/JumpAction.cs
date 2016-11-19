using UnityEngine;
using System.Collections;

public class JumpAction : Action {

	public float force;

	public override void ExecuteAction (GameObject other)
	{
		other.GetComponent<JumpAccelerator> ().Jump (force);

	}

}
