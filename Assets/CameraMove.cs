using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public float speed = 5.0f;
	// Update is called once per frame
	void Update () {
        float xAxisValue = Input.GetAxis("Horizontal")*speed;
        float zAxisValue = Input.GetAxis("Vertical")*speed;
        float yAxisValue = Input.GetAxis("Mouse ScrollWheel") * speed;
        
        if (Camera.current != null)
        {
            transform.Translate(new Vector3(xAxisValue, yAxisValue, zAxisValue));
        }
    }
}
