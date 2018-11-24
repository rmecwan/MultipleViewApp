using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;

	// Use this for initialization
	void Start () {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x; // Set equal to the box collider's length 
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < -groundHorizontalLength) {
            RepositionBackground();
        }
	}

    private void RepositionBackground() {
        Vector2 groundOffset = new Vector2(groundHorizontalLength * 2, 0); // Set it twice as big
        transform.position = (Vector2) transform.position + groundOffset; // Set the position of the ground object 
                                                                            //to the current position plus the offset
    }
}
