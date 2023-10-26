using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenerVida : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bool vidaRecuperada = GameCoins.Instance.GanarVida();
            if (vidaRecuperada)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
