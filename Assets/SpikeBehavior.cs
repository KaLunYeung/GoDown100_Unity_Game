﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBehavior : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player" )
        {
            print("touched");
            collision.gameObject.GetComponent<PlayerHealthSystem>().TakeDamage(80);

            

        }




    }
}