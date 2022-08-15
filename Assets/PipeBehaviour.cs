using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Keep moving the obstacles to the left at the speed set in the speed variable
        transform.position += Vector3.left * speed * Time.deltaTime;
        
    }
}
