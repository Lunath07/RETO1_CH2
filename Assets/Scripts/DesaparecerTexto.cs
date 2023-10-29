using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DesaparecerTexto : MonoBehaviour
{
    public string Escena;
    public Animator animacion;

    private void OnTriggerEnter2D(Collider2D other)
    {
        TMP_Text texto = other.GetComponent<TMP_Text>();
        if (texto != null) 
        {
            //texto.gameObject.SetActive(false);
            Destroy(other.gameObject );
        }
    }

    private void CambioEscena()
    {
        SceneManager.LoadScene(Escena);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            animacion.SetBool("Animacion", true);
            Invoke("CambioEscena",4.0f);
        }
    }
}
