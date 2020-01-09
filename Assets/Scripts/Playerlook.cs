using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playerlook : MonoBehaviour
{

    [SerializeField] private string xinput, yinput;
    [SerializeField]  private float mouseSensitivity;
    [SerializeField] private Transform playerbodypos;
    private float xAxislimit;

    private void Awake()
    {
        LockCursor();
    }
    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        xAxislimit = 0;
    }


    // Update is called once per frame
    void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(xinput) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(yinput) * mouseSensitivity * Time.deltaTime;
        xAxislimit += mouseY;
        if(xAxislimit> 90.0F)
        {
            xAxislimit = 90.0F;
            mouseY = 0.0F;
            limitXAxisrotation(270.0f);

        }

        if (xAxislimit < -90.0F)
        {
            xAxislimit = -90.0F;
            mouseY = 0.0F;
            limitXAxisrotation(90.0f);

        }
        transform.Rotate(Vector3.left * mouseY);
        playerbodypos.Rotate(Vector3.up * mouseX);
    }
    private void limitXAxisrotation(float value)
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.x = value;
        transform.eulerAngles = rotation;
    }
}
