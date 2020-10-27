using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    [SerializeField] GameObject[] tilePrefabs;
    [SerializeField] int numberOfTiles = 3;
    [SerializeField] public Transform player;
    public float zSpawn = 0;
    public float tileLength = 35;
    private List<GameObject> activeTiles = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numberOfTiles; i++)
        {
            if (i == 0)
                SpawnTile(0);
            else
                SpawnTile(Random.Range(0, tilePrefabs.Length));
            
                
        }
        
    }

    

    // Update is called once per frame
    void Update()
    {


        if (player.position.z -35 > zSpawn - (numberOfTiles * tileLength))

        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }

    }
    private void SpawnTile(int tileIndex)
    {
        GameObject create = Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(create);
        zSpawn += tileLength;
    }
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

}
