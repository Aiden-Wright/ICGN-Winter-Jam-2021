using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flames : MonoBehaviour
{
    public Sprite[] flames = new Sprite[4457];
    int spr = 0;
    private void FixedUpdate()
    {
        GetComponent<SpriteRenderer>().sprite = flames[(++spr)%4457];
        
    }
}
