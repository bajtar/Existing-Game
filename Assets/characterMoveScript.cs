using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveScript : MonoBehaviour

{ 
    public ProjectileBehaviour ProjectilePrefab;
    public Transform LaunchOffset;
    [SerializeField] private float speed;
     private Rigidbody2D rb;
     private Animator anim;
     private void Awake()
     {
         anim = GetComponent<Animator>();
         rb = GetComponent<Rigidbody2D>();
         
     }

     private void Update()
     {
         float h = Input.GetAxisRaw("Horizontal");
         rb.velocity = new Vector2(h * speed, rb.velocity.y);

         if (h != 0 )
         {
             transform.localScale = new Vector3(h, 1, 1);
         }

         if (Input.GetButtonDown("Fire1"))
         {
             Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
         }

         anim.SetBool("isRunning", rb.velocity.x != 0);
         //If player is pressing 'A' or 'D'
         if (rb.velocity.x > 0 || rb.velocity.x < 0)
         {
             anim.SetBool("isRunning", true);
         }
         else
         {
             anim.SetBool("isRunning", false);
         }
     }
     
    
    
    
    
    
    
    
    
}
