using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraY : MonoBehaviour
{
    public GameObject Personaje;
    void Update()
    {
        Vector3 position = transform.position;
        position.y = Personaje.transform.position.y;
        transform.position = position;
    }
}
