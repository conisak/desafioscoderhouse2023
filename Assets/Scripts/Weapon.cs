using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
 public GameObject bullet;
 public Transform pointOfShoot;


    void Start()
    {
        Shoot();
            
    }
    void Update()
    {
        
    }
    void Shoot()
    {
        Instantiate(bullet, pointOfShoot);

    }
}
