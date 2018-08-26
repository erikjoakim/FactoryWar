using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public Canvas canvas;
	// Use this for initialization
	void Start () {
        canvas.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.M))
        {
            canvas.gameObject.SetActive(true);
        }
	}

    public void BuildRoadClicked()
    {
        Debug.Log("Clicked Button");
        canvas.gameObject.SetActive(false);
    }
}
