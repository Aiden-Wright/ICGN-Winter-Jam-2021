using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public float intensity;
    float val = 0;
    // Update is called once per frame
    void Update()
    {
        val += Time.deltaTime;
        transform.position = new Vector3(transform.position.x, intensity * Mathf.Sin(speed * val), 0f);
    }
}
