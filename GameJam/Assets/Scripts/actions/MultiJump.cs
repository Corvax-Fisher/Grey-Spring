using UnityEngine;
using System.Collections;

public class MultiJump : MultiConditionAction {


	public override void ExecuteCollectedItemsAction (GameObject other)
	{
		Debug.Log ("möp");
		other.GetComponent<JumpAccelerator> ().Jump (10f);
	}

}
