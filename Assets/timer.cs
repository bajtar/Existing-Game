using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float time = 10;

    [SerializeField] private TextMeshProUGUI timerText;
    
    
    // Start is called before the first frame update
    public void AddTime()
    {
        time += 2;
    }
//IDKIDKIDK
    public void SubtractTime()
    {
        time -= 2;
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timerText.text = time.ToString("00.000");
    }
}
