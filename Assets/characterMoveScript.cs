using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMoveScript : MonoBehaviour

{ 
    public ProjectileBehaviour ProjectilePrefab;
    public Transform LaunchOffset;
    [SerializeField] private float speed;
     private Rigidbody2D body;

     private void Awake()
     {
         body = GetComponent<Rigidbody2D>();
     }

     private void Update()
     {
         body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

         if (Input.GetButtonDown("Fire1"))
         {
             Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
         }
     }
    
    
    
    
    
    
    
    
}
