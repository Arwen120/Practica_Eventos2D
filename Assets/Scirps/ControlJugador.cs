
using UnityEngine;

using TMPro;

using UnityEngine.UI;





public class ControlJugador : MonoBehaviour
{
    public float velocidadNormal = 5f;
    public float velocidadSigilo = 2f;

    private float velocidadActual;

    public TMP_Text textoMonedas;
    public int monedas = 0;

    public Slider barraVida;
    public int vida = 100;

    public Transform escondite;
    public float velocidadEscondite = 3f;
    private bool yendoAlEscondite = false;

    void Start()
    {
        velocidadActual = velocidadNormal;
    }

    public void RecogerMoneda()
    {
        monedas++;
        textoMonedas.text = "Monedas: " + monedas;
    }

    public void PerderVida(int cantidad)
    {
        vida -= cantidad;

        if (vida < 0)
        {
            vida = 0;
        }

        barraVida.value = vida;
    }





    public void ActivarSigilo()
    {
        velocidadActual = velocidadSigilo;
    }

    public void ActivarModoNormal()
    {
        velocidadActual = velocidadNormal;
    }

    private bool enSigilo = false;

    public void CambiarModo()
    {
        if (enSigilo == false)
        {
            ActivarSigilo();
            enSigilo = true;
        }
        else
        {
            ActivarModoNormal();
            enSigilo = false;
        }
    }

    public void IrAlEscondite()
    {
        yendoAlEscondite = true;
    }


    void Update()
    {
        if (yendoAlEscondite == true)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                escondite.position,
                velocidadEscondite * Time.deltaTime
            );

            if (Vector2.Distance(transform.position, escondite.position) < 0.1f)
            {
                transform.position = escondite.position;
                yendoAlEscondite = false;
            }
        }
        else
        {
            float movimientoX = Input.GetAxisRaw("Horizontal");

            Vector2 movimiento = new Vector2(movimientoX, 0);

            transform.Translate(movimiento * velocidadActual * Time.deltaTime);
        }
    }

}
