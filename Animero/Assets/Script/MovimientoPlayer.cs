using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    [SerializeField] float MovimientoHorizontalPlayer,
        MovimientoVerticalPlayer,
        fuerzaMovimiento ,
        fuerzaSalto,
        VelocidadEscalado;
    [SerializeField] bool enSuelo, escalar,escalando;
    [SerializeField] Transform controladorSuelo;
    [SerializeField] LayerMask queEsSuelo;    
    [SerializeField] Vector2 dimensionesCaja;


    Rigidbody2D rigidbody;
    SpriteRenderer spriteRenderer;
   


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        dimensionesCaja = controladorSuelo.localScale;       
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoHorizontalPlayer = Input.GetAxisRaw("Horizontal");        
        if (MovimientoHorizontalPlayer != 0) {
            MoverPlayer();
            GiroPlayer();
        }

       


        
        if (Physics2D.OverlapBox(controladorSuelo.position, dimensionesCaja, 0f, queEsSuelo)) {
            enSuelo = true;
        }
        else { enSuelo = false; }


        MovimientoVerticalPlayer = Input.GetAxisRaw("Vertical");
        if (MovimientoVerticalPlayer != 0 && escalar)
        {

            print("escale");
            transform.position += Vector3.up * MovimientoVerticalPlayer * VelocidadEscalado * Time.deltaTime;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;

        }
        else if (MovimientoVerticalPlayer == 0 && escalar) {
                

        }
        else if (MovimientoVerticalPlayer != 0 && !escalar && enSuelo)
        {
            SaltoPlayer();
            print("Salte");
           
        }





    }

    public void MoverPlayer() {
        transform.position += Vector3.right * MovimientoHorizontalPlayer * Time.deltaTime * fuerzaMovimiento;
    }

    

    public void SaltoPlayer() {
        //rigidbody.AddForce(new Vector3(0, fuerzaSalto, 0));
        rigidbody.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);

    }

    public void GiroPlayer() {
        if (MovimientoHorizontalPlayer > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (MovimientoHorizontalPlayer < 0){
            spriteRenderer.flipX = true;
        }
    }

    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Escalar"))
        {
            escalar = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Escalar"))
        {
            escalar = false;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(controladorSuelo.position, dimensionesCaja);
    }


}
