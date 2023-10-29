using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vidas : MonoBehaviour
{
    public GameObject PanelGameOver;
    public TMP_Text vidaText;
    private int vidas = 3;
    private Vector3 posicionInicial;
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        vidaText.text = "" + vidas;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fantasma"))
        {
            vidas--;
            PerdidaVida();
            
            if (vidas == 0)
            {
                PanelGameOver.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    private void PerdidaVida()
    {
        transform.position = posicionInicial;
    }
}
