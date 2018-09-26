using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelController : MonoBehaviour {

    private bool IsDragging;
    private bool firstTouch = true;
    private Vector3 TouchPosition;
    public float Sensitivity = 2.0f;
    private Vector3 _rotation;

    public Text Scaler;

    // Use this for initialization
    void Start () {
        Scaler.text = "2.0";
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Scaler.text);
        float Sensitivity;
        bool isFloat = float.TryParse(Scaler.text, out Sensitivity);
        
        if (Input.GetMouseButtonDown(0))
        {
            TouchPosition = Input.mousePosition;
            IsDragging = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            IsDragging = false;
        }

        if (IsDragging)
        {
            Vector2 deltaSwipe = TouchPosition - Input.mousePosition;
            float rotationAmount = deltaSwipe.x * Sensitivity;
            float newZ = transform.rotation.z + rotationAmount;
            _rotation.z = rotationAmount;
            transform.Rotate(_rotation);
            //transform.rotation = target;

            TouchPosition = Input.mousePosition;
        }
        
    }
}
