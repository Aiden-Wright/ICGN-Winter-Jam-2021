using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flames : MonoBehaviour
{
    public Sprite[] flames = new Sprite[3];
    int spr = 0;
    public int frameTime;
    
    
    
    private void FixedUpdate()
    {
        int index = (++spr) % (flames.Length * frameTime);
        GetComponent<SpriteRenderer>().sprite = flames[index/frameTime];
    }
}
