using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPJ : MonoBehaviour
{
    public GameObject Jugador;
    private float Adelante;
    private float Suavizado;
    public float Subir;
    public float Tiempo;
    private Vector3 JugadorPost;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TiempoEspera());
    }
    // Update is called once per frame
    void Update()
    {

        JugadorPost = new Vector3(Jugador.transform.position.x, Jugador.transform.position.y, transform.position.z);

        if (Jugador.transform.localScale.x == 1) //Derecha
        {
            JugadorPost = new Vector3(JugadorPost.x + Adelante, JugadorPost.y + Subir, transform.position.z);
        }
        else if (Jugador.transform.localScale.x == -1) // Izquierda
        {
            JugadorPost = new Vector3(JugadorPost.x - Adelante, JugadorPost.y + Subir, transform.position.z);
        }
        transform.position = Vector3.Lerp(transform.position, JugadorPost, Suavizado * Time.deltaTime);
    }

    IEnumerator TiempoEspera()
    {
        yield return new WaitForSecondsRealtime(Tiempo);
        Adelante = 4;
        Suavizado = 4;
    }
}
