using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
  public float xMin, xMax, zMin, zMax;
}

public class InputController : MonoBehaviour
{
  public float scale;
  //public float tilt;
  public Boundary boundary;

  //private Rigidbody rb;

  //void Awake()
  //{
  //  rb = GetComponent<Rigidbody>();
  //}

  void FixedUpdate()
  {
    float moveHorizontal = -Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    //rb.velocity = movement * speed;

    transform.Rotate(
      moveVertical * Time.fixedDeltaTime * scale,
      0f,
      moveHorizontal * Time.fixedDeltaTime * scale
    );

    Vector3 negativeEulerAngles = transform.eulerAngles;
    negativeEulerAngles.x = negativeEulerAngles.x < 180f ? negativeEulerAngles.x : negativeEulerAngles.x - 360;
    negativeEulerAngles.z = negativeEulerAngles.z < 180f ? negativeEulerAngles.z : negativeEulerAngles.z - 360;

    transform.rotation = Quaternion.Euler(
      Mathf.Clamp(negativeEulerAngles.x, boundary.xMin, boundary.xMax),
      0f,
      Mathf.Clamp(negativeEulerAngles.z, boundary.zMin, boundary.zMax)
      );
  }
}