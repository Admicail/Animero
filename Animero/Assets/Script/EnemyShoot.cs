using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject disparo;
    public float timeForShoot;
    public float shootCoolDown;
    public float shootSpeed;

    // Start is called before the first frame update
    void Start()
    {
        shootCoolDown = timeForShoot;
    }

    // Update is called once per frame
    void Update()
    {
        shootCoolDown -= Time.deltaTime;
        if (shootCoolDown < 0)
        {
            GameObject cross = Instantiate(disparo, transform.position, Quaternion.identity);
            cross.GetComponent<Rigidbody2D>().AddForce(new Vector2(shootSpeed, 0f), ForceMode2D.Force);
            shootCoolDown = timeForShoot;

        }
    }
}
