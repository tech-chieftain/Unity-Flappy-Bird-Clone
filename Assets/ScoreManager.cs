using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Set the score to 0
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Keep updating the text to show the score
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
