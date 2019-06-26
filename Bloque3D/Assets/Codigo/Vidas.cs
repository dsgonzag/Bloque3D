using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class Vidas : MonoBehaviour
{

    public static int vidas = 3;
    public Text textoVidas;

    public pelota pelota;
    public Barra barra;

    // Start is called before the first frame update
    void Start()
    {
        ActualizarMarcadorVidas();
            
    }

    void ActualizarMarcadorVidas()
    {
        textoVidas.text = "Vidas: " + Vidas.vidas;
    }
   public void PerderVida()
    {
        Vidas.vidas--;
        ActualizarMarcadorVidas();

        barra.Reset();
        pelota.Reset();
    }
}
