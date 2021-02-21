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
    GameObject foliage;
    SpriteRenderer foliageSpr;
    public bool instance;
    [SerializeField] ParticleSystem fire;
    // Start is called before the first frame update
    void Start()
    {
        foliage = new GameObject("Folliage");
        foliageSpr = foliage.AddComponent<SpriteRenderer>();
        foliage.transform.parent = gameObject.transform;
        foliage.transform.position = gameObject.transform.position;
        hydration = UnityEngine.Random.Range(0f, 1f);
        SetFolliageSprite();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(onFire)
        {

        }
    }

    void SetFolliageSprite()
    {
        if (hydration <= 0)
            Destroy(foliage);
        int enumNum = (int)type;
        foliageSpr.sprite = sprites[enumNum].sprite[(int)(hydration * sprites[enumNum].sprite.Length)];
        foliageSpr.sortingOrder = 1;
    }
    public void SetOnFire()
    {
        Instantiate<ParticleSystem>(fire, gameObject.transform);
    }
}
