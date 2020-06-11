using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30f;
    private float lowerBound = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bounds checking for the top of the screen
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        else if(transform.position.z < lowerBound)
        {
            // Bounds checking for the lower part of the screen
            // This is an animal that reaches the lower bound causing you to lose
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
