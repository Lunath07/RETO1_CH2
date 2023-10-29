using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarMusica : MonoBehaviour
{
    
    void Start()
    {
        GameObject.FindGameObjectWithTag("Musica").GetComponent<Musica>().PlayMusic();
    }
}
