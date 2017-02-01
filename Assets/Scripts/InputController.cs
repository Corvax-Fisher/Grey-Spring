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
  public Boundary boundary;

  void FixedUpdate()
  {
    float moveHorizontal = 0f;
    float moveVertical = 0f;

#if UNITY_EDITOR
    if (UnityEditor.EditorApplication.isRemoteConnected)
    {
      moveHorizontal = -Input.acceleration.x;
      moveVertical = Input.acceleration.y;
    } else
    {
      moveHorizontal = -Input.GetAxis("Horizontal");
      moveVertical = Input.GetAxis("Vertical");
    }

    Quaternion to = Quaternion.Euler(
      moveVertical * scale,
      0f,
      moveHorizontal * scale
    );
    transform.rotation = Quaternion.Lerp(transform.rotation, to, Time.fixedDeltaTime * speed);
#elif UNITY_STANDALONE || UNITY_WEBGL
    moveHorizontal = -Input.GetAxis("Horizontal");
    moveVertical = Input.GetAxis("Vertical");

    Quaternion to = Quaternion.Euler(
      moveVertical * scale,
      0f,
      moveHorizontal * scale
    );
    transform.rotation = Quaternion.Lerp(transform.rotation, to, Time.fixedDeltaTime * speed);

#elif UNITY_ANDROID || UNITY_IOS
    moveHorizontal = -Input.acceleration.x;
    moveVertical = Input.acceleration.y;

    Quaternion to = Quaternion.Euler(
      moveVertical * scale,
      0f,
      moveHorizontal * scale
    );
    transform.rotation = Quaternion.Lerp(transform.rotation, to, Time.fixedDeltaTime * speed);
#endif

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