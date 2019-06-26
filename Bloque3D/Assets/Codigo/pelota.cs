﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{
    public float velocidadInicial = 600f;
    public Rigidbody rig;

    bool enJuego;
    Vector3 posicionInicial;
    public Transform barra;

    

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }
    public void Reset()
    {
        transform.position = posicionInicial;
        transform.SetParent(barra);
        enJuego = false;
        DetenerMovimiento();
    }
    public void DetenerMovimiento()
    {
        rig.isKinematic = true;
        rig.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (!enJuego && Input.GetButtonDown("Fire1")) {

            enJuego = true;
            transform.SetParent(null);
            rig.isKinematic = false;
            rig.AddForce(new Vector3(velocidadInicial, 0));
        } 
    }
}
