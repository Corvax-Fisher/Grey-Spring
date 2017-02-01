using UnityEngine;
using System.Collections;

public class TeleportTarget : MonoBehaviour {


	public Vector3 getLocation(){
		return this.gameObject.transform.position;
	}


	public Vector3 getLocationRelative(Vector3 shift){
		return getLocation() + shift;
	}
}
