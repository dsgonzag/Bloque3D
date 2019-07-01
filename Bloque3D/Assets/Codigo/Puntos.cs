using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public Text textoPuntos;
    // Start is called before the first frame update
    public SonidoFinPartida sonidosFinpartida;
    void Start()
    {
        ActualizarMarcadorPuntos();
    }

    void ActualizarMarcadorPuntos()
    {
        textoPuntos.text = "Puntos: " + Puntos.puntos;
    }
    
    public void GanarPunto()
    {
        Puntos.puntos++;
        ActualizarMarcadorPuntos();

        sonidosFinpartida.NivelCompletado();
        
    }
}
