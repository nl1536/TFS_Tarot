using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elementMovement : MonoBehaviour {

    bool fadeIn;
    public bool fortuneTitleReveal;
    public bool fortuneTextReveal;
    public bool guideTextReveal;

    public Sprite sunTree;
    public Sprite sunJar;
    public Sprite sunField;
    public Sprite moonTree;
    public Sprite moonJar;
    public Sprite moonField;

    public int fortune;

    // Use this for initialization
    void Start() {

        fadeIn = false;
        fortuneTitleReveal = false;
        fortuneTextReveal = false;
        guideTextReveal = false;

        GetComponent<SpringJoint2D>().connectedAnchor = new Vector2(0f, 0f);

        fortune = Random.Range(0, 5);

    }

    // Update is called once per frame
    void Update() {

        if (fortune == 0) {
            GetComponent<SpriteRenderer>().sprite = sunTree;
        }
        else if (fortune == 1) {
            GetComponent<SpriteRenderer>().sprite = sunJar;
        }
        else if (fortune == 2) {
            GetComponent<SpriteRenderer>().sprite = sunField;
        }
        else if (fortune == 3) {
            GetComponent<SpriteRenderer>().sprite = moonTree;
        }
        else if (fortune == 4) {
            GetComponent<SpriteRenderer>().sprite = moonJar;
        }
        else if (fortune == 5) {
            GetComponent<SpriteRenderer>().sprite = moonField;
        }

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

        GetComponent<SpringJoint2D>().connectedAnchor = new Vector2(-5.5f, GetComponent<Transform>().position.y);

        yield return new WaitForSeconds(1.25f);

        fortuneTitleReveal = true;

        yield return new WaitForSeconds(.25f);

        fortuneTextReveal = true;

        yield return new WaitForSeconds(1f);

        guideTextReveal = true;
    }
}
