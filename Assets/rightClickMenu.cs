using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightClickMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void onGUI () {
        if (Input.GetButtonDown("RMB"))
        {
            var mousepos = Input.mousePosition;
            Debug.Log(mousepos);
            GUI.Button(new Rect(mousepos.x, mousepos.y, 50, 30), "Click");
        }
        
    }
}
