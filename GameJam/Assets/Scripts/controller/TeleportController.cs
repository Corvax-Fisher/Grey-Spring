using UnityEngine;
using System.Collections;

public class TeleportController : MonoBehaviour {


	public void teleportTo(GameObject target){
		teleportTo (target.transform.position+new Vector3(0,1,0));
	}

	public void teleportTo(Vector3 position){
		this.gameObject.transform.position= position;
	}
}
