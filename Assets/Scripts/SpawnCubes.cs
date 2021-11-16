using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    public GameObject spawnObj;
    public int gridX;
    public int gridZ;
    public float gridOffset;
    public Vector3 origin;
    // Start is called before the first frame update
    void Start()
    {
        SpawnGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnGrid()
    {
        for(int x = 0; x < gridX; x++)
        {
            for(int z = 0; z < gridZ; z++)
            {
                Vector3 spawnPoints = new Vector3(x * gridOffset, 0, z * gridOffset) + origin;
                PickandSpawn(spawnPoints, Quaternion.identity);
            }
        }
    }
    void PickandSpawn(Vector3 positionToSpawn, Quaternion rotation)
    {
        GameObject cube = Instantiate(spawnObj, positionToSpawn, rotation);
    }
}
