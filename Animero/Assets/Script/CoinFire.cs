using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFire : MonoBehaviour
{
    public int valor = 1;
    public AudioClip sonidoFuego;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameCoins.Instance.SumarPuntos(valor);
            Destroy(this.gameObject);
            AudioManager.Instance.ReproducirSonido(sonidoFuego);
        }
    }
}
