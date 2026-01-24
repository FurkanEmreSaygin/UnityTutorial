using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed = 0.5f; // Speed of rotation around the Y-axis.
    public GameObject onCollectEffect; // Effect to play when collected.


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        //destroy the collectible when the player touches it
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            // Instantiate the onCollectEffect at the position of the collectible
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
 
    }

    void FixedUpdate()
    {
        
    }
}
