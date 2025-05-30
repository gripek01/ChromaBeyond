using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiyatro3Kitap : MonoBehaviour
{
    public GameObject Not;
    public GameObject bilezik;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Not.SetActive(true);
            bilezik.SetActive(true);
        }
    }
}
