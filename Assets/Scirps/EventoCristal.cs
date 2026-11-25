using System;
using UnityEngine;

public class EventoCristal : MonoBehaviour
{
    public static event Action<Transform> CristalRecogido;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CristalRecogido?.Invoke(collision.transform);

            Destroy(gameObject);
        }
    }
}