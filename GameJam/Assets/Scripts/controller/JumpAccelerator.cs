using UnityEngine;
using System.Collections;

public class JumpAccelerator : MonoBehaviour {

	public void Jump(float force,Vector3 direction){
	
		Rigidbody rb = this.GetComponent<Rigidbody>();

		if (rb != null) {

			rb.AddForce (direction * force,ForceMode.Impulse);

		} else {
			Debug.Log ("rigidbody null");
		}
	
	}
}
