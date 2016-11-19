using UnityEngine;
using System.Collections;

public class RotateAndMoveBall : MonoBehaviour {
	
	// speed of the ball
	double speed = 5.0;

	void Update () {
		// base movement off of the camera, not the object.
		// reset the camera's X to zero, so that it is always looking horizontally.
		float x = Camera.main.transform.localEulerAngles.x;
		Camera.main.transform.localEulerAngles.x = 0;

		// now collect the movement stuff This is generic direction and rotation.
		Vector3 direction = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
		Vector3 rotation = new Vector3(Input.GetAxis("Vertical"),0,-Input.GetAxis("Horizontal"));

		// prevent the ball from moving faster diagnally
		if(direction.magnitude > 1.0) direction.Normalize();
		if(rotation.magnitude > 1.0) rotation.Normalize();


		// reorientate the movement stuff to align to the camera.
		direction = Camera.main.transform.TransformDirection(direction);
		rotation = Camera.main.transform.TransformDirection(rotation);

		// multiply the direction by the speed and deltaTime
		direction *= Time.deltaTime * speed;
		// multiply the rotation by the speed, deltaTime, circumference and 10...
		// dunno why I had to add 10, but it works
		rotation *= Time.deltaTime * speed * (2 * Mathf.PI * transform.localScale.magnitude) * 10;

		// now update the position by the direction
		transform.Translate(direction, Space.World);
		// and rotate by the rotation
		transform.Rotate(rotation, Space.World);

		// return the camera's x rotation.
		Camera.main.transform.localEulerAngles.x = x;
	}


}
