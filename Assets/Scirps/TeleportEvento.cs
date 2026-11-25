using UnityEngine;

public class TeleportEvento : MonoBehaviour
{
    public Vector3 puntoDestino = new Vector3(4, 2, 0);

    private void OnEnable()
    {
        EventoCristal.CristalRecogido += Teletransportar;
    }

    private void OnDisable()
    {
        EventoCristal.CristalRecogido -= Teletransportar;
    }

    private void Teletransportar(Transform jugador)
    {
        transform.position = puntoDestino;
    }
}