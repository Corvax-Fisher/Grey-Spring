using UnityEngine;
using System.Collections;

public class ColorOtherObjects : Action {


	public GameObject[] otherObjects;

	public override void ExecuteAction (GameObject other)
	{

		foreach(GameObject go in otherObjects){

			go.GetComponent<Renderer> ().material.color = this.gameObject.GetComponent<ColorCondition> ().color.color;

		}

	}
}
