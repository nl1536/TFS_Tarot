using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortune == 0) {
            GetComponent<Text>().text = "Oh... yikes.";
        }
        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortune == 1) {
            GetComponent<Text>().text = "Looks like you're gonna get hungry soon.";
        }
        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortune == 2) {
            GetComponent<Text>().text = "Yeah... it's not looking good for you.";
        }
        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortune == 3) {
            GetComponent<Text>().text = "You're gonna die.";
        }
        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortune == 4) {
            GetComponent<Text>().text = "... Look, I personally don't agree with your lifestyle, but you do you I guess.";
        }
        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortune == 5) {
            GetComponent<Text>().text = "Alone again... naturally.";
        }

        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().fortuneTextReveal &&
            GetComponent<Text>().color.a < 255) {
            GetComponent<Text>().color = new Color(GetComponent<Text>().color.r,
                                                   GetComponent<Text>().color.g,
                                                   GetComponent<Text>().color.b,
                                                   GetComponent<Text>().color.a + .025f);
        }
	}
}
