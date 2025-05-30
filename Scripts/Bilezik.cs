using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bilezik : MonoBehaviour
{
    public GameObject bilezikAlindi, DigerSahne;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            bilezikAlindi.SetActive(true);
            DigerSahne.SetActive(true);
        }
    }
}
