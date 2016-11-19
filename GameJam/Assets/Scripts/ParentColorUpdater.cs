using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ParentColorUpdater : MonoBehaviour {


	private Renderer[] rend;
	// Use this for initialization
	void Start () {
		rend = this.gameObject.GetComponentsInChildren<Renderer> ();
	}
	

	void FixedUpdate () {
	
		ColorCondition cd = this.gameObject.GetComponentInParent<ColorCondition> ();

		if (cd != null && cd.color!=null && cd.color.color!=null) {

			foreach (Renderer r in rend) {
				r.material.color= cd.color.color;
			}
		
		}


	}

}
