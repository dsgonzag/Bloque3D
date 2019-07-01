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

    public GameObject gameOver;

    public SonidoFinPartida sonidoFinPartida;

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
        if (vidas <= 0) return;
        Vidas.vidas--;
        ActualizarMarcadorVidas();
        if(vidas<=0)
        {
            sonidoFinPartida.GameOver();
            //Mostrar Game Over
            gameOver.SetActive(true);
        }
        else
        {
            barra.Reset();
            pelota.Reset();
        }
        
    }
}
