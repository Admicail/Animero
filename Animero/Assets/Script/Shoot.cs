using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameCoins.Instance.PerderVida();

            collision.gameObject.GetComponent<Personaje>().RecibirGolpe();

            Destroy(this.gameObject);
        }
        else if (collision.gameObject.CompareTag("Muro"))
        {
            Destroy(this.gameObject);
        }

    }
}
