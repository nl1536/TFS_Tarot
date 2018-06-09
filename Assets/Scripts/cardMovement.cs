using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardMovement : MonoBehaviour {

    public bool chosen;
    GameObject[] notChosenCards;

    // Use this for initialization
    void Start () {

        chosen = false;

        GetComponent<SpringJoint2D>().connectedAnchor = new Vector2(GetComponent<Transform>().position.x, -9f);

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<SpringJoint2D>().connectedAnchor = new Vector2(GetComponent<Transform>().position.x, 0f);
        }

        if (chosen) {
            GetComponent<SpringJoint2D>().connectedAnchor = new Vector2(0f, 0f);
            GetComponent<Transform>().localScale = new Vector2(GetComponent<Transform>().localScale.x + (4.5f - GetComponent<Transform>().localScale.x) / 10f,
                                                               GetComponent<Transform>().localScale.y + (7.5f - GetComponent<Transform>().localScale.y) / 10f);
            if (GetComponent<Transform>().localScale.x >= 4.5f) {
                GetComponent<Transform>().localScale = new Vector2(4.5f, GetComponent<Transform>().localScale.y);
            }
            if (GetComponent<Transform>().localScale.y >= 7.5f) {
                GetComponent<Transform>().localScale = new Vector2(GetComponent<Transform>().localScale.x, 7.5f);
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
        tag = "chosenCard";
        chosen = true;
    }
}
