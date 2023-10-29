using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransporte : MonoBehaviour
{
    public Transform transportador1;
    public Transform transportador2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pared1"))
        {
            TeleTransportar2();
        }
        else if (other.gameObject.CompareTag("Pared2"))
        {
            TeleTransportar1();
        }
    }

    private void TeleTransportar1()
    {
        transform.position = transportador1.position;
    }

    private void TeleTransportar2()
    {
        transform.position = transportador2.position;
    }

}
