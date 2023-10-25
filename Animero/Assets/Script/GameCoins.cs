using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCoins : MonoBehaviour
{
    public int PuntosTotales { get { return puntosTotales; } }
    private int puntosTotales;
    // Start is called before the first frame update
    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales = PuntosTotales + puntosASumar;
    }
}
