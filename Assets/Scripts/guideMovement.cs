using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class guideMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.FindWithTag("element").GetComponent<elementMovement>().guideTextReveal) {

            GetComponent<Text>().color = new Color(GetComponent<Text>().color.r,
                                                   GetComponent<Text>().color.g,
                                                   GetComponent<Text>().color.b,
                                                   GetComponent<Text>().color.a + .025f);

            if (Input.GetKeyDown(KeyCode.Space)) {
                SceneManager.LoadScene("Tarot");
            }
        }
		
	}
}
