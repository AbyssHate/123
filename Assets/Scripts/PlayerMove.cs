using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Camera PlayerCamera;
    public Transform Player;
    public float Speed;

    public void FixedUpdate()
    {
        Ray ray = PlayerCamera.ScreenPointToRay(Input.mousePosition);

        Plane plane = new Plane(new Vector3(0f, 1f, 0f),Vector3.zero);

        float distance;
        plane.Raycast(ray, out distance);
        Vector3 point = ray.GetPoint(distance);
        point.x = Mathf.Clamp(point.x, 0f, 0f);
        point.z = Mathf.Clamp(point.z, -8f, 10f);

        Player.position = (point * Speed * Time.deltaTime);
        
    }

  
}
