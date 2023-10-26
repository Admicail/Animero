using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    public TextMeshProUGUI puntos;
    public GameObject[] vidas; 
    // Start is called before the first frame update
    void Start()
    {
        puntos.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        puntos.text = GameCoins.Instance.PuntosTotales.ToString();
    }

    public void ActualizarPuntos(int puntosTotales)
    {
        puntos.text = puntosTotales.ToString();
    }
    public void DesactivarVida(int salud)
    {
        vidas[salud].SetActive(false);
    }
    public void ActivarVida(int salud)
    {
        vidas[salud].SetActive(true);
    }
}
