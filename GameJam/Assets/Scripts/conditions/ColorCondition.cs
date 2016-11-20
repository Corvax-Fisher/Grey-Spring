using UnityEngine;
using System.Collections;

public class ColorCondition : ICondition {


	public ColorData color;


	void Start () {
		if (color != null && color.color != null) {
			gameObject.GetComponent<Renderer> ().material.color = color.color;
		}
	}

	public override bool isConditionFullfilled (GameObject gameObjectOther)
	{
		Color current = gameObjectOther.GetComponent<Renderer> ().material.color;
		
		return current != null && color != null && current.Equals (color.color);
	}


}
