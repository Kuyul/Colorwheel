using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelController2 : MonoBehaviour
{

    private bool IsDragging;
    private bool firstTouch = true;
    private Vector3 TouchPosition;
    public float Sensitivity = 2.0f;
    private Vector3 _rotation;
    private Vector3 firstVector;
    private float angle;

    public Text Scaler;

    // Use this for initialization
    void Start()
    {
        firstVector = new Vector2(0, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            TouchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            IsDragging = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            IsDragging = false;
        }

        
        if (IsDragging)
        {
            //Vector2 deltaSwipe = TouchPosition - Input.mousePosition;
            angle = Vector2.SignedAngle(TouchPosition, Camera.main.ScreenToWorldPoint(Input.mousePosition));
            Debug.Log(angle);
            _rotation.z = angle;
            transform.Rotate(_rotation);
            //transform.rotation = target;

            TouchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        

    }
}
