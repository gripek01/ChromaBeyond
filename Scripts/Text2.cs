using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text2 : MonoBehaviour
{
    public float delay = 5f; // Ka� saniye sonra kapans�n

    private void OnEnable()
    {
        // Obje aktif oldu�unda geri say�m ba�las�n
        Invoke("Deactivate", delay);
    }

    private void OnDisable()
    {
        // Obje tekrar aktif edilirse �nceki Invoke'lar iptal edilir
        CancelInvoke("Deactivate");
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
