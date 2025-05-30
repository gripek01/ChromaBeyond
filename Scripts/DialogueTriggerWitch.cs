using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerWitch : MonoBehaviour
{
    public GameObject dialogueImg;
    private bool playerInRange = false;

    public int witchNumber;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            dialogueImg.SetActive(true);
        }
        if (playerInRange && Input.GetKeyDown(KeyCode.R))
        {
            gameObject.SetActive(false);
            dialogueImg.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
