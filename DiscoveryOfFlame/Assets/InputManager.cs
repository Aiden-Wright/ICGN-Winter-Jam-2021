using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static Vector2 vector2;

    private void Update()
    {
        vector2 = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical"));
    }
}
