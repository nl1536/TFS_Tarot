using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elementMovement : MonoBehaviour {

    bool fadeIn;

    // Use this for initialization
    void Start() {

        fadeIn = false;

        GetComponent<SpringJoint2D>().connectedAnchor = new Vector2(0f, 0f);

    }

    // Update is called once per frame
    void Update() {

        if (GameObject.FindWithTag("chosenCard").GetComponent<cardMovement>().revealedElements) {
            ElementReveal();
        }

        if (fadeIn) {
            if (GetComponent<SpriteRenderer>().color.a < 255f) {
                GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r,
                                                                 GetComponent<SpriteRenderer>().color.g,
                                                                 GetComponent<SpriteRenderer>().color.b,
                                                                 GetComponent<SpriteRenderer>().color.a + .025f);
            }
        }
	}

    public void ElementReveal() {
        Debug.Log("element reveal!");

        StartCoroutine(ElementRevealCoroutine());
        GameObject.FindWithTag("chosenCard").GetComponent<cardMovement>().revealedElements = false;
    }

    IEnumerator ElementRevealCoroutine() {
        yield return new WaitForSeconds(1.25f);

        fadeIn = true;

        yield return new WaitForSeconds(2f);

        GetComponent<SpringJoint2D>().connectedAnchor = new Vector2(-6f, GetComponent<Transform>().position.y);
    }
}
