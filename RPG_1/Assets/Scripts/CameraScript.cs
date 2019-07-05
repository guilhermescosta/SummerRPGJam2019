using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public bool isLooking;

    public float speedX;
    public float speedY;

    public float axisX;
    public float axisY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isLooking) {
            Look();
        }
    }

    public void Look() {
        axisX += speedX * Input.GetAxis("Mouse X");
        axisY -= speedY * Input.GetAxis("Mouse Y");

        axisX = Mathf.Clamp(axisX, -90f, 90f);
        axisY = Mathf.Clamp(axisY, -90f, 90f);

        transform.eulerAngles = new Vector3(axisY, axisX, 0.0f);
    }
}
