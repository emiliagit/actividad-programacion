using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  
    public GameObject objetoPrefab;   
    public float intervaloDeSpawn = 2f; 

    void Start()
    {
        intervaloDeSpawn = Random.Range(1, 5); //ejercicio 2

        StartCoroutine(SpawnObjectCoroutine());
    }

    IEnumerator SpawnObjectCoroutine()
    {
        while (true)
        {
            SpawnObject();

            yield return new WaitForSeconds(intervaloDeSpawn);

            intervaloDeSpawn = Random.Range(1, 5); //ejercicio 2

        }
    }

    void SpawnObject()
    {
       
        Vector3 spawnPosition = new Vector3(Random.Range(-7f, 5f), 0f, Random.Range(-7f, 5f));

       
        Instantiate(objetoPrefab, spawnPosition, Quaternion.identity);
    }
}


