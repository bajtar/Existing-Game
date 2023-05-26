using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{
    private Rigidbody2D rb;
   [SerializeField] public float forceAmount = 10;
 
   
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * forceAmount, ForceMode2D.Impulse);
        
    }

 

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        Destroy(gameObject);
       



        if (collision.gameObject.tag == "Projectile")
        {
             Timer timer = FindObjectOfType<Timer>();
             ScoreScript scoreScript = FindObjectOfType<ScoreScript>();
             
             
             if (tag == "Good")
             {
                 timer.AddTime();
                 scoreScript.AddScore();
               

             }
             if (tag == "Bad")
             {
                 timer.SubtractTime();
                
                 

                  
             }
            

            
        }
        
    }
}
