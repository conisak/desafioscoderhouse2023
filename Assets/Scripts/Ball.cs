using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public float damage;
    void Start()
    {
        
    }

  
    void Update()
    {
        transform.position += direction * speed;
    }
}
