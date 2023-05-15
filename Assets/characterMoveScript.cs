using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMoveScript : MonoBehaviour

{ 
    public ProjectileBehaviour ProjectilePrefab;
    public Transform LaunchOffset;
    [SerializeField] private float speed;
     private Rigidbody2D rb;

     private void Awake()
     {
         rb = GetComponent<Rigidbody2D>();
     }

     private void Update()
     {
         rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

         if (Input.GetButtonDown("Fire1"))
         {
             Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
         }
     }
    
    
    
    
    
    
    
    
}
