using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFija : MonoBehaviour
{
    public GameObject Personaje;
    void Update()
    {
        Vector3 position = transform.position;
        position.x = Personaje.transform.position.x;
        transform.position = position;
    }
}
