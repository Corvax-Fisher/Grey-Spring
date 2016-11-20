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
  public float speed;
  //public float tilt;
  public Boundary boundary;

  //private Rigidbody rb;

  //void Awake()
  //{
  //  rb = GetComponent<Rigidbody>();
  //}

  void FixedUpdate()
  {
    float moveHorizontal = 0f;
    float moveVertical = 0f;

#if UNITY_STANDALONE
    moveHorizontal = -Input.GetAxis("Horizontal");
    moveVertical = Input.GetAxis("Vertical");

    transform.Rotate(
      moveVertical * Time.fixedDeltaTime * scale,
      0f,
      moveHorizontal * Time.fixedDeltaTime * scale
    );
#elif UNITY_ANDROID
    moveHorizontal = -Input.acceleration.x;
    moveVertical = Input.acceleration.y;

    Quaternion to = Quaternion.Euler(
      moveVertical * scale,
      0f,
      moveHorizontal * scale
    );
    transform.rotation = Quaternion.Lerp(transform.rotation, to, Time.fixedDeltaTime * speed);
#endif
    //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    //rb.velocity = movement * speed;


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