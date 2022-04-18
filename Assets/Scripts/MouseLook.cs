using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxis { MouseXAndY = 0, MouseX = 1, MouseY = 2};
    public RotationAxis axes = RotationAxis.MouseXAndY;

    public float senX = 15f;
    public float senY = 15f;

    public float minX = -360f;
    public float maxX = 360f;

    public float minY = -60f;
    public float maxY = 60f;

    float rotY = 0f;

    // Update is called once per frame
    void Update()
    {
        if (axes == RotationAxis.MouseXAndY)
        {
            float rotX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * senX;
            rotY += Input.GetAxis("Mouse Y") * senY;
            rotY = Mathf.Clamp(rotY, minY, minX);

            transform.localEulerAngles = new Vector3(-rotY, rotX, 0);
        }
        else if (axes == RotationAxis.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * senX, 0);
        }
        else
        {
            rotY += Input.GetAxis("Mouse Y") * senY;
            rotY = Mathf.Clamp(rotY, minY, maxY);

            transform.localEulerAngles = new Vector3(-rotY, transform.localEulerAngles.y, 0);
        }
    }
}
