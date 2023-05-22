using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
  public float Speed = 6f;
 

  private void Start()
  {
    
  }


  private void Update()
  {
    transform.position += transform.up * Time.deltaTime * Speed;
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    
    Destroy(gameObject);
  }
  
}
