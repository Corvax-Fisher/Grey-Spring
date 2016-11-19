using UnityEngine;
using System.Collections;

public abstract class Action : MonoBehaviour {



	public Color triggerCondition;


	void OnTriggerEnter(Collider other){
		
		Color current = other.gameObject.GetComponent<Renderer> ().material.color;

		if (current.Equals (triggerCondition)) {
			this.ExecuteAction(other.gameObject);
		}
	}

	public abstract void ExecuteAction (GameObject other);


}
