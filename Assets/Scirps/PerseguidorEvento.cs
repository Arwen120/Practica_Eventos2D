using UnityEngine;

public class PerseguidorEvento : MonoBehaviour
{
    public float velocidad = 2f;

    private Transform jugador;
    private bool persiguiendo = false;

    private void OnEnable()
    {
        EventoCristal.CristalRecogido += EmpezarPersecucion;
    }

    private void OnDisable()
    {
        EventoCristal.CristalRecogido -= EmpezarPersecucion;
    }

    private void EmpezarPersecucion(Transform objetivo)
    {
        jugador = objetivo;
        persiguiendo = true;
    }

    private void Update()
    {
        if (persiguiendo && jugador != null)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                jugador.position,
                velocidad * Time.deltaTime
            );
        }
    }
}