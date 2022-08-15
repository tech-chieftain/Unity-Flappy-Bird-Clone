using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour {
    // The GameManager object reference
    public GameManger gameManger;

    // The speed at which the bird moves
    public float velocity = 1;

    // The object that gives the bird physics attributes like mas and gravity
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start () {
        // Reference the Rigidbody2D component
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update () {
        // If the user presses the left mouse button, the bird will get an upward force
        if (Input.GetMouseButtonDown (0)) {
            rb.velocity = Vector2.up * velocity;
        }

        // Transform the angle of the bird according to the Y-axis to face the correct direction (Upward or downward)
        transform.eulerAngles = new Vector3 (0, 0, rb.velocity.y * 10f);
    }

    private void OnCollisionEnter2D (Collision2D collision) {
        // If the bird collides with anything, the game is over
        gameManger.GameOver ();
    }
}