using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float moveSpeed = 10.0f;
    public GameObject cameraRig;
    public GameObject centerEye;
    private Vector2 touchpad;

    void Update()

    {

        //Player movement
        touchpad = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        transform.eulerAngles = new Vector3(0, centerEye.transform.localEulerAngles.y, 0);
        transform.Translate(Vector3.forward * moveSpeed * touchpad.y * Time.deltaTime);
        transform.Translate(Vector3.right * moveSpeed * touchpad.x * Time.deltaTime);
        cameraRig.transform.position = transform.position;

    }

}
