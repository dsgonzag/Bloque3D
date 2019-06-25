﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    public float velocidad = 0.4f;

    // Use thuus for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
        float posX = transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime);
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }
}
