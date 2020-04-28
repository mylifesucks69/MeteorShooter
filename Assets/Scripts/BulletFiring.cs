﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFiring : MonoBehaviour
{

    public Transform firepoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;


    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Fire1"))
        {
            // Play sound
            FindObjectOfType<AudioManager>().Play("fire");
            
            Shoot();
            
        }
    }


    void Shoot()
    {
        // Instantiate bullet
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();


        rb.AddForce(firepoint.up * bulletForce,ForceMode2D.Impulse);

    }
}
