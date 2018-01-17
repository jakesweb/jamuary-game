using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    public float movementDistance;
    public Rigidbody2D rb2d;

    private Vector2 currentPosition;
    private Vector2 move;
    private bool flip = true;

	// Use this for initialization
	void Start () {
        currentPosition = this.transform.position;
        move.x = 2;
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveEnemy(flip);
    }

    void MoveEnemy (bool direction)
    {
        if (direction)
        {
            for (var i = 0; i < movementDistance; i++)
            {
                rb2d.position += move * Time.deltaTime;
            }
            flip = !flip;
        }
        else
        {
            for (var i = 0; i < movementDistance; i++)
            {
                rb2d.position -= move * Time.deltaTime;
            }
            flip = !flip;
        }
    }
}
