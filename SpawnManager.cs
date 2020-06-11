using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;
    //public int animalIndex;

    private float startDelay = 2.2f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Reapeatably spawn a random animal 
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //Spawn an animal using a key press (Used for debugging)
        // if (Input.GetKeyDown(KeyCode.S))
        // {
        //     SpawnRandomAnimal();
        // }
    }

    void SpawnRandomAnimal()
    {
        
            int animalIndex = Random.Range(0,animalPrefabs.Length);

            // Randomly generate animal index and spawn position
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
