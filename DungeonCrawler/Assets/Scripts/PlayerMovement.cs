using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D myRB;

    float speed = 5f;

	// Use this for initialization
	void Start () {

        myRB = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.D))
        {
            myRB.velocity = new Vector2(speed, myRB.velocity.y);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            myRB.velocity = new Vector2(0f, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            myRB.velocity = new Vector2(-speed, myRB.velocity.y);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            myRB.velocity = new Vector2(0f, 0f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            myRB.velocity = new Vector2(myRB.velocity.x, speed);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            myRB.velocity = new Vector2(0f, 0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            myRB.velocity = new Vector2(myRB.velocity.x, -speed);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            myRB.velocity = new Vector2(0f, 0f);
        }

    }
}
