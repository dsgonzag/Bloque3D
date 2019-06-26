using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques : MonoBehaviour
{
    public GameObject efectoParticulas;
    public Puntos puntos;

    // Start is called before the first frame update
    void OnCollisionEnter()
    {
        Instantiate(efectoParticulas, transform.position, Quaternion.identity);
        Destroy(gameObject);
        puntos.GanarPunto();
    }

}
