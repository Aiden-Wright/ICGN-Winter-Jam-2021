using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject TilePrefab;
    int chunkSize = 8;
    GameObject Tiles; //A folder for all tiles in the scene
    //SortedDictionary<Vector2, Tile> grid = new SortedDictionary<Vector2, Tile>();
    Dictionary<Vector2, Tile> grid = new Dictionary<Vector2, Tile>();
    private void Start()
    {
        Tiles = new GameObject("Tiles");
        Tiles.transform.parent = gameObject.transform;
        //Loads the initial chunks for the scene
        LoadChunk(new Vector2(-1, -1));
        LoadChunk(new Vector2(-1, 0));
        LoadChunk(new Vector2(0, -1));
        LoadChunk(new Vector2(0, 0));
        grid[new Vector2(0, 0)].SetOnFire();
        grid[new Vector2(1, 0)].SetOnFire();
        grid[new Vector2(1, 1)].SetOnFire();
        grid[new Vector2(0, 1)].SetOnFire();
    }
    /// <summary>
    /// Load a 8x8 tile chunk at the location specified.
    /// </summary>
    /// <param name="location">
    /// The location of the chunk where 1 is the space of 1 chunk.
    /// </param>
    public void LoadChunk(Vector2 location)
    {
        SpawnTile(location * chunkSize);
    }

    /// <summary>
    /// Creates a tile at the world space location indicated
    /// </summary>
    /// <param name="location">
    /// The location of a specific tile in 
    /// </param>
    void SpawnTile(Vector2 location)
    {
        for(int i = 0; i < chunkSize; ++i)
        {
            for (int j = 0; j < chunkSize; ++j)
            {
                GameObject newTile = Instantiate(TilePrefab, Tiles.transform, true);
                Tile chunkTile = newTile.GetComponent<Tile>();
                newTile.transform.position = new Vector2(location.x + i, location.y + j);
                grid.Add(newTile.transform.position, chunkTile);
            }
        }
    }

    public Tile getTile(Vector2 loc)
    {
        return grid[loc];
    }
}
