using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    private int Puntaje = 0;
    private int contador = 0;
    private int aumento = 0;
    private int TotalDot = 0;
    private int recolectados = 0;
    public TMP_Text scoreT;
    public GameObject[] cherry;
    public GameObject panelWin;

    private void Start()
    {
        TotalDot = GameObject.FindGameObjectsWithTag("Puntos").Length;
    }

    private void Update()
    {
        if (recolectados >= TotalDot)
        {
            panelWin.SetActive(true);
            Time.timeScale = 0;
            //scoreT.text = "Ganaste";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Puntos"))
        {
            contador++;
            recolectados++;
            Destroy(other.gameObject);
            Puntaje += 10;
            scoreT.text = "Puntaje: " + Puntaje;
            if (contador == 30)
            {
                ActivarCherry();
                aumento++;
            }
            
        }
        if (other.gameObject.CompareTag("Cherry"))
        {
            Destroy(other.gameObject);
            Puntaje += 100;
            scoreT.text = "Puntaje: " + Puntaje;
        }
    }

    private void ActivarCherry()
    {
        contador = 0;
        cherry[aumento].SetActive(true);
    }
}
