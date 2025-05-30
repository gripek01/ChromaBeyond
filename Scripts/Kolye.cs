using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kolye : MonoBehaviour
{
    public GameObject text, sahneDegis;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            text.SetActive(true);
            sahneDegis.SetActive(true);
        }
    }
}
