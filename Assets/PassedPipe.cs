using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassedPipe : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // When the bird passes the pipe, increase the score
        ScoreManager.score++;
    }

}
