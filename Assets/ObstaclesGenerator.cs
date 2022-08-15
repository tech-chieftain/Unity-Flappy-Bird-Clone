using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour {
    // The max time between every obstacle generated
    public float maxTime = 2;
    // The current timer setting
    public float timer = 0;
    // The obstacle game object itself
    public GameObject obstacle;
    // The height that the obstacles will be generated at
    public float height;
    // Start is called before the first frame update
    void Start () {
        // Create a new object from the beginning
        GameObject newObstacle = Instantiate (obstacle);

        // Change its position to the height set in the height variable
        newObstacle.transform.position = transform.position + new Vector3 (0, Random.Range (-height, height), 0);
        Destroy (newObstacle, 10);

    }

    // Update is called once per frame
    void Update () {
        // When the time is above the limit, create a new obstacle
        if (timer > maxTime) {
            GameObject newObstacle = Instantiate (obstacle);
            newObstacle.transform.position = transform.position + new Vector3 (0, Random.Range (-height, height), 0);

            Destroy (newObstacle, 10);
            // Reset the timer
            timer = 0;
        }

        // Increase the timer
        timer += Time.deltaTime;

    }
}