using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
   public float rotSpeed = 2000;
   void OnMouseDrag()
   {
      float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad * Time.deltaTime;
      
      transform.RotateAround(Vector3.up, -rotY);
   }
}
