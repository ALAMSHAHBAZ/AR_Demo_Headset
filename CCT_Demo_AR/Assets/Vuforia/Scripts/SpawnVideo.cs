using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVideo : MonoBehaviour
{
    public GameObject spawnee;
    public float spawnDelay=3.0f;
    public Transform newPosition;

    void Start()
    {
        //Invoke("SpawnObject", spawnDelay);
        Instantiate(spawnee, transform.position, Quaternion.identity);
    }

    public void SpawnObject()
    {
        Instantiate(spawnee, newPosition.position, Quaternion.identity);

    }


}
