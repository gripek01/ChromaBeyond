using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text2 : MonoBehaviour
{
    public float delay = 5f; // Kaç saniye sonra kapansýn

    private void OnEnable()
    {
        // Obje aktif olduðunda geri sayým baþlasýn
        Invoke("Deactivate", delay);
    }

    private void OnDisable()
    {
        // Obje tekrar aktif edilirse önceki Invoke'lar iptal edilir
        CancelInvoke("Deactivate");
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
