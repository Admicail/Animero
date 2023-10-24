using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //public int LifeTotal = 3;
    //public int enemySpeed = 20;
    //public Rigidbody rb;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}
    //void Update()
    //{
    //    rb.velocity = transform.right * enemySpeed;   
    //}
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
}
