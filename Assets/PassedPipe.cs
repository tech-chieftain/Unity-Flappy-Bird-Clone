using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassedPipe : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreManager.score++;
    }

}
