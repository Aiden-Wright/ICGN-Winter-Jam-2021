using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public SpriteLookup.TerrainType type;
    public Vector2 location;
    public float hydration;
    public bool onFire;
    //int enums = Enum.GetNames(SpriteLookup.getEnum()).Length;
    public SpriteLookup.TerrainTypeSprite[] sprites;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
