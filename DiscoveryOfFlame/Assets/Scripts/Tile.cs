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
    public Sprite burn;
    GameObject foliage;
    GameObject flame;
    SpriteRenderer foliageSpr;
    public bool instance;
    public float drySpeed = 0.001f;
    [SerializeField] GameObject fire;
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
        if(onFire && type != SpriteLookup.TerrainType.rocks)
        {
            Tile t = GameObject.Find("TilesManager").GetComponent<TileManager>().getTile(InputManager.vector2 + location);
            t.hydration -= drySpeed;
            t.SetFolliageSprite();
            if (!t.onFire && t.hydration < .75f)
                t.SetOnFire();
            hydration -= drySpeed;
            if (hydration < 0f)
            {
                Destroy(foliage);
                Destroy(flame);
                onFire = false;
                GetComponent<SpriteRenderer>().sprite = burn;
            }
        }
    }

    void SetFolliageSprite()
    {
        if (hydration <= 0)
            Destroy(foliage);
        int enumNum = (int)type;
        if (foliage != null)
        {
            foliageSpr.sprite = sprites[enumNum].sprite[(int)(hydration * sprites[enumNum].sprite.Length)];
            foliageSpr.sortingOrder = 1;
        }
    }
    public void SetOnFire()
    {
        flame = Instantiate<GameObject>(fire, transform);
        onFire = true;
    }
}
