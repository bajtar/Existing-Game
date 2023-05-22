using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplayScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoretext;
    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = "Score: " + ScoreScript.score.ToString();
    }
}
