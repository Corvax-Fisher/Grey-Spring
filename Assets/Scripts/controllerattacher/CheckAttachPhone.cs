using UnityEngine;
using System.Collections;

public class CheckAttachPhone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		if (Application.platform==RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {
			this.gameObject.AddComponent<PlayerController> ();
		}

	}
}
