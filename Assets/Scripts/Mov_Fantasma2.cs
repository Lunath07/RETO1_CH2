using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Fantasma2 : MonoBehaviour
{
    public Transform[] puntos;
    public float velocidad = 4f;

    private int puntoPosicion = 0;
    private Vector3 objetivo;

    void Start()
    {
        StartCoroutine(Movimiento());
    }

    private IEnumerator Movimiento()
    {
        while (true)
        {
            Vector3 objetivo = puntos[puntoPosicion].position; ;
            transform.LookAt(objetivo);

            while (transform.position != objetivo)
            {
                transform.position = Vector3.MoveTowards(transform.position, objetivo, velocidad * Time.deltaTime);
                yield return null;
            }

            if (Vector3.Distance(transform.position, objetivo) < 0.1f)
            {
                puntoPosicion = (puntoPosicion + 1) % puntos.Length;
                objetivo = puntos[puntoPosicion].position;
            }

        }
    }
}
