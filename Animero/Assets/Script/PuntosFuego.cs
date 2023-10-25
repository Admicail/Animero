using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuntosFuego : MonoBehaviour
{
    public GameCoins gameCoin;
    public TextMeshProUGUI puntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        puntos.text = gameCoin.PuntosTotales.ToString();
    }
}
