using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //This will destroy the animal and anything that collides with it. 
        //This is how you handle impact in games
        //Make sure your Collider is set to "isTrigger"
        Destroy(gameObject);
        Destroy(other.gameObject);
    }

}
