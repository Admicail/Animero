using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{

    private Rigidbody2D rigidbody;
    private BoxCollider2D boxCollider;
    private bool mirarDerecha = true;
    private Animator animator;
    private bool puedeMoverse = true;
    [SerializeField] List<Transform> wayPoints = null;
    public float velocidad;
    public float distanciaCambio;
    byte siguientePosicion = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isRunning", true);
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[siguientePosicion].transform.position, velocidad * Time.deltaTime);

        if (Vector2.Distance(transform.position, wayPoints[siguientePosicion].transform.position) < distanciaCambio)
        {
            siguientePosicion++;
            if (siguientePosicion >= wayPoints.Count)
                siguientePosicion = 0;
        }
    }
}
