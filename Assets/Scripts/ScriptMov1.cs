using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class ScriptMov1 : MonoBehaviour
{
    public Vector3 position;
    public float heal;
    public float speed=2f;
    public Vector3 direction;
    public float damage;

    public void Move()
    {
        transform.position+=speed*direction;
    }

    public void Heal()
        {
        heal +=1;
        Debug.Log(heal); 
        }


    public void Damage()
    {
        heal -= 1;
        Debug.Log(damage);
    }

    void Update() {
        Move();
            Heal();
            Damage();

        }


        }

    

 

        


        
    

