using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFantasma: MonoBehaviour
{
    public Transform[] puntos; 
    public float velocidad = 4f; 

    private int puntoPosicion = 0;
    private Vector3 objetivo;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        objetivo = puntos[puntoPosicion].position;
        spriteRenderer = GetComponent <SpriteRenderer>();
    }

    void Update()
    {
        Vector3 direccion = objetivo - transform.position;

        if (direccion.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (direccion.x < 0)
        {
            spriteRenderer.flipX = true;
        }

        transform.Translate(direccion.normalized * velocidad * Time.deltaTime);

        if (Vector3.Distance(transform.position, objetivo) < 0.1f)
        {
            puntoPosicion = (puntoPosicion + 1) % puntos.Length;
            objetivo = puntos[puntoPosicion].position;
        }
    }
}
