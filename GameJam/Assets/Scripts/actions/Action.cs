using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Action : MonoBehaviour {


	private ICondition[] conditions;

	public Action[] optionalActions;

	void Start () {
		this.conditions = this.gameObject.GetComponents<ICondition> ();
	}


	void OnTriggerEnter(Collider other){

		bool isFullfilled = true;	

		foreach (ICondition condition in conditions) {
			if (!condition.isConditionFullfilled (other.gameObject)) {
				isFullfilled = false;
			}
		}

		if (isFullfilled) {
			this.ExecuteAction(other.gameObject);

			foreach(Action action in optionalActions){
				action.ExecuteAction (other.gameObject);
			}

		}

	}

	public abstract void ExecuteAction (GameObject other);


}
