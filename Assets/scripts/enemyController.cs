using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    public float movementDistance;
    public Rigidbody2D rb2d;
    public Vector2 moveSpeed;
    public int health = 20;

    private Vector2 originalPosition;
    private bool flip = true;

	// Use this for initialization
	void Start () {
        originalPosition.x = rb2d.position.x;
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveEnemy(flip);
    }

    void MoveEnemy(bool direction)
    {
        if (direction) {
            rb2d.position += moveSpeed * Time.deltaTime;

            if (rb2d.position.x >= (originalPosition.x + movementDistance)) {
                flip = !flip;
            }
        } else {
            rb2d.position -= moveSpeed * Time.deltaTime;

            if (rb2d.position.x <= (originalPosition.x - movementDistance)) {
                flip = !flip;
            }
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        health -= 1;

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
