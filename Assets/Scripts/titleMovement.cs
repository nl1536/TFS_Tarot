using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class titleMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortune == 0) {
            GetComponent<Text>().text = "Barren Tree at Daytime";
        }
        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortune == 1) {
            GetComponent<Text>().text = "Cookie Jar at Daytime";
        }
        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortune == 2) {
            GetComponent<Text>().text = "Golden Prairie at Daytime";
        }
        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortune == 3) {
            GetComponent<Text>().text = "Barren Tree at Nighttime";
        }
        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortune == 4) {
            GetComponent<Text>().text = "Cookie Jar at Nighttime";
        }
        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortune == 5) {
            GetComponent<Text>().text = "Golden Prairie at Nighttime";
        }

        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortuneTitleReveal &&
            GetComponent<Text>().color.a < 255) {
            GetComponent<Text>().color = new Color(GetComponent<Text>().color.r,
                                                   GetComponent<Text>().color.g,
                                                   GetComponent<Text>().color.b,
                                                   GetComponent<Text>().color.a + .025f);
        }
    }
}
