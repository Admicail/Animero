using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] List<Transform> wayPoints = null;
    public float velocidad;
    public float distanciaCambio;
    byte siguientePosicion = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,wayPoints[siguientePosicion].transform.position,velocidad * Time.deltaTime);

        if (Vector2.Distance(transform.position,wayPoints[siguientePosicion].transform.position) < distanciaCambio)
        {
            siguientePosicion++;
            if (siguientePosicion >= wayPoints.Count)
                siguientePosicion = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            GameCoins.Instance.PerderVida();

            collision.gameObject.GetComponent<Personaje>().RecibirGolpe();
        }
    }
}
