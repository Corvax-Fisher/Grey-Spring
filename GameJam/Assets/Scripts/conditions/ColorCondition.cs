using UnityEngine;
using System.Collections;

public class ColorCondition : ICondition {


	public Color color;

	public override bool isConditionFullfilled (GameObject gameObject)
	{
		Color current = gameObject.GetComponent<Renderer> ().material.color;
		
		return current.Equals (color);
	}


}
