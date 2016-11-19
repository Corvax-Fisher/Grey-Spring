using UnityEngine;
using System.Collections;

public class JumpAction : Action {


	public Vector3 forceDirection = Vector3.zero;
	public float force;

	public override void ExecuteAction (GameObject other)
	{
		other.GetComponent<JumpAccelerator> ().Jump (force);
	}

}
