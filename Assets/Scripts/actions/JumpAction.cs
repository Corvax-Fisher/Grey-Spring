using UnityEngine;
using System.Collections;

public class JumpAction : Action {

	public float force;

	public override void ExecuteAction (GameObject other)
	{
    Vector3 up = transform.rotation * Vector3.up;
		other.GetComponent<JumpAccelerator> ().Jump(force,up);

	}

}
