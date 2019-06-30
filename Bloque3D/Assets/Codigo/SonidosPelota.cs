using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosPelota : MonoBehaviour
{
    public AudioSource rebote;
    public AudioSource punto;
    // Start is called before the first frame update


    void OnCollisionEnter(Collision otro)
    {
       if(otro.gameObject.CompareTag("Bloques"))
        {
            punto.Play();
        }
        else{
            rebote.Play();
        }
    }
}
