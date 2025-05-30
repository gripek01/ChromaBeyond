using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mektup : MonoBehaviour
{
    public static Mektup instance;

    public bool mektupAlindi;
    public GameObject zamanlayiciCanvas, Text2, MektupAlindiText;

    public GameObject Juliet1, Juliet2;

    private void Start()
    {
        instance = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text2Open();
            mektupAlindi = true;
            zamanlayiciCanvas.SetActive(true);
            gameObject.transform.position = new Vector3(10000f, 10000f, 10000f);
            MektupAlindiText.SetActive(true);
            Juliet1.SetActive(false);
            Juliet2.SetActive(true);
        }
    }
    public void text2Open()
    {
        Text2.SetActive(true);
    }
}
