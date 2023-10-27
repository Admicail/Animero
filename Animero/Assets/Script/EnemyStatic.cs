using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyStatic : MonoBehaviour
{
    public int vidas;
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
            Debug.Log("No pego");
        }
        else if (collision.gameObject.CompareTag("Espada"))
        {
            vidas -= 1;
            if (vidas == 0)
            {
                Destroy(this.gameObject);
            }
            Debug.Log("Pego");
        }
    }

}
