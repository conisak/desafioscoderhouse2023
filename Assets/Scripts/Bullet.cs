using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 movement; 
    public float speed; 


    void Start()
    {
        
    }

 
    void Update()
    {
        transform.position += movement * speed; 

        
    }
}
