using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D enemys)
    {
        if (enemys.tag.Contains("Enemy"))
        {
            enemys.transform.Rotate(0f, 180f, 0f);
        }
    }
}
