using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCoins : MonoBehaviour
{
    public static GameCoins Instance { get; private set; }
    public Puntos puntos;
    public int escena;

    public int PuntosTotales { get { return puntosTotales; } }
    private int puntosTotales;
    private int vidas = 5;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Eso esta mal, no deben haber mas GameManager asi");
        }
    }
    
    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales = PuntosTotales + puntosASumar;
        puntos.ActualizarPuntos(PuntosTotales);
    }

    public void PerderVida()
    {
        vidas -= 1;
        if (vidas == 0)
        {
            SceneManager.LoadScene(escena);
        }
        puntos.DesactivarVida(vidas);
    }
    public bool GanarVida()
    {
        if (vidas == 5)
        {
            return false;
        }
        puntos.ActivarVida(vidas);
        vidas += 1;
        return true;

    }
}
