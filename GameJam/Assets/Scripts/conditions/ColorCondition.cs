using UnityEngine;
using System.Collections;

public class ColorCondition : ICondition {


	public ColorData color;


	void Start () {
		gameObject.GetComponent<Renderer> ().material.color = color.color;
	}

	public override bool isConditionFullfilled (GameObject gameObject)
	{
		Color current = gameObject.GetComponent<Renderer> ().material.color;
		
		return current.Equals (color.color);
	}


}
