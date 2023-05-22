using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform trans;
    public GameObject[] bubbles;
    [SerializeField] public float wait = 1f;
    public float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;    
        
        if (timer >= wait)
        {
            int random = Random.Range(0, bubbles.Length);
            GameObject bubble = bubbles[random];
            Instantiate(bubble, transform.position, Quaternion.identity);
            timer = 0;
        }
 
       
    }
}
