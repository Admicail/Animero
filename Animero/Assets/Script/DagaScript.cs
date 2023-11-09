using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DagaScript : MonoBehaviour
{
    public float Velocidad;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localEulerAngles.y == 0)
        {
            transform.position += new Vector3(Velocidad * Time.deltaTime, 0, 0);
        }
        else if (true)
        {
            transform.position += new Vector3(-Velocidad * Time.deltaTime, 0, 0);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("Enemy"))
        {
            collision.gameObject.GetComponentInParent<EnemyStatic>().vidas -= 1;
            Destroy(gameObject);
        }
    }
}
