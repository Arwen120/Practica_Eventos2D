using UnityEngine;

public class Trampa : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ControlJugador jugador = collision.GetComponent<ControlJugador>();

            if (jugador != null)
            {
                jugador.PerderVida(20);
            }
        }
    }
}
