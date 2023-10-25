using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFire : MonoBehaviour
{
    public int valor = 1;
    public GameCoins gamePoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gamePoints.SumarPuntos(valor);
            Destroy(this.gameObject);
        }
    }
}
