using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerSnow : MonoBehaviour
{
    public GameObject[] snowPrefabs;
    float startDelay = 0.5f;
    float spawnInterval = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSnow", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void SpawnSnow()
    {
        int snowIndex = Random.Range(0,snowPrefabs.Length);  
        float posX = Random.Range(0,25);
        float posZ = Random.Range(0,25);
        Vector3 spawnPos = new Vector3(posX, 10, posZ);
        Instantiate(snowPrefabs[snowIndex], spawnPos, snowPrefabs[snowIndex].transform.rotation);
    }
}
