using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardMovement : MonoBehaviour {

    public bool chosen;
    bool revealedFortune;
    public bool revealedElements;
    GameObject[] notChosenCards;

    // Use this for initialization
    void Start () {

        chosen = false;
        revealedFortune = false;
        revealedElements = false;

        GetComponent<SpringJoint2D>().connectedAnchor = new Vector2(GetComponent<Transform>().position.x, 0f);
        GetComponent<Rigidbody2D>().drag = 1f;

	}
	
	// Update is called once per frame
	void Update () {

        if (chosen) {
            GetComponent<Transform>().localScale = new Vector2(GetComponent<Transform>().localScale.x + (0.9f - GetComponent<Transform>().localScale.x) / 10f,
                                                               GetComponent<Transform>().localScale.y + (0.9f - GetComponent<Transform>().localScale.y) / 10f);

            if (revealedFortune == false) {
                GetComponent<SpringJoint2D>().connectedAnchor = new Vector2(0f, 0f);
                FortuneReveal();
            }

            notChosenCards = GameObject.FindGameObjectsWithTag("card");
            foreach (GameObject card in notChosenCards) {
                card.GetComponent<SpringJoint2D>().dampingRatio = 1f;
                card.GetComponent<SpringJoint2D>().connectedAnchor = new Vector2(card.GetComponent<Transform>().position.x, -9f);
            }
        }
		
	}

    private void OnMouseDown() {
        GetComponent<SpringJoint2D>().dampingRatio = 1f;
        GetComponent<Rigidbody2D>().drag = 5f;
        tag = "chosenCard";
        chosen = true;
    }

    void FortuneReveal() {
        StartCoroutine(FortuneRevealCoroutine());
        revealedElements = true;
        revealedFortune = true;
    }

    IEnumerator FortuneRevealCoroutine() {
        yield return new WaitForSeconds(3.27f);

        GetComponent<SpringJoint2D>().connectedAnchor = new Vector2(-5.5f, GetComponent<Transform>().position.y);
    }
}
