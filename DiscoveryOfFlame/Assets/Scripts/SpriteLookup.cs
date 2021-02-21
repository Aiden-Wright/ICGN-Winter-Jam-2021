using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteLookup : MonoBehaviour
{
    public enum TerrainType
    {
        bush,
        grass,
        rocks,
        river
    }
    [System.Serializable]
    public struct TerrainTypeSprite
    {
        public Sprite[] sprite;
    }

    public static Type getEnum()
    {
        return typeof(TerrainType);
    }
}
