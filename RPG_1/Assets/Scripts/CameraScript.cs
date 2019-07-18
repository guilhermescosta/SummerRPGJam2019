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

    
    public Player _player;

    public Quaternion _cameraStart;
    

    // Start is called before the first frame update
    void Start()
    {
        _cameraStart = this.transform.rotation;
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isLooking) {
          //  LookMode();
        }


    }

    public void LookMode() {
      
        axisX += speedX * Input.GetAxis("Mouse X");
        axisY -= speedY * Input.GetAxis("Mouse Y");

        axisX = Mathf.Clamp(axisX, -90f, 90f);
        axisY = Mathf.Clamp(axisY, -90f, 90f);

        
         transform.eulerAngles = new Vector3(axisY, axisX, 0.0f);
    }

    public void Look() {
        if (!isLooking)
        {
            _player.isMove = false;
           
            isLooking = true;

        }
        else
        {
           
            this.transform.localRotation = _cameraStart;
            isLooking = false;
            _player.isMove = true;
        }
    }
}
