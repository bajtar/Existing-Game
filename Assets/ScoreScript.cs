using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoretext;
    public static int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    public void AddScore()
    {
        score += 1;
        // change text here.
        scoretext.text = "Score: " + score.ToString();

    }

   
}
