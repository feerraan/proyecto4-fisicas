using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    private float spawnLimit = 8f;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject powerupPrefab;
    


    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(enemyPrefab, 
        GenerateRandomPosition(), 
        Quaternion.identity);

        Instantiate(powerupPrefab,
         new Vector3 (0,0,8),
         Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void Awake()
    {
        
    }

    private Vector3 GenerateRandomPosition()
    {
        float x = Random.Range(-spawnLimit, spawnLimit);
        float z = Random.Range(-spawnLimit, spawnLimit);
        return new Vector3(x, 0, z) ;
    }
}
