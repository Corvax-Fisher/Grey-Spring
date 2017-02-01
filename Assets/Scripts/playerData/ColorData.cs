using UnityEngine;
using System.Collections;

public class ColorData : MonoBehaviour {

	public Color color;

	void Start () {
		gameObject.GetComponent<Renderer> ().material.color = color;
	} 


	void OnTriggerEnter(Collider other){
			other.gameObject.GetComponent<Renderer> ().material.color = this.color;
	}

}
