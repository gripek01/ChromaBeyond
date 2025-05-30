using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tablo : MonoBehaviour
{
    public int hangiTablo;
    bool mesafe;

    public GameObject TabloName;
    private void Update()
    {
        if (mesafe && Input.GetKeyDown(KeyCode.T))
        {
            if (hangiTablo == 1)
            {
                SceneManager.LoadScene("Tiyatro1");
            }
            else if (hangiTablo == 2)
            {
                SceneManager.LoadScene("Tiyatro2");
            }
            else if (hangiTablo == 3)
            {
                SceneManager.LoadScene("Tiyatro3Baslangic");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mesafe = true;
            TabloName.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mesafe = false;
            TabloName.SetActive(false);
        }
    }
}
