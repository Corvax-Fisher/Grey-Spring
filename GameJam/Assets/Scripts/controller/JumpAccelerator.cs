using UnityEngine;
using System.Collections;

public class JumpAccelerator : MonoBehaviour {

	public void Jump(float force){
	
		Rigidbody rb = this.GetComponent<Rigidbody>();

		if (rb != null) {

			rb.AddForce (Vector3.up * force,ForceMode.Impulse);

		} else {
			Debug.Log ("rigidbody null");
		}
	
	}
}
