using UnityEngine;
using System.Collections;

public class CheckAttachOther : MonoBehaviour {

	public float scale;
	public Boundary boundary;

	private InputController controller;

	// Use this for initialization
	void Start () {

		if (!(Application.platform==RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)) {
			controller = this.gameObject.AddComponent<InputController>();

			controller.scale = scale;
			controller.boundary = boundary;
		}

	
	}
}
