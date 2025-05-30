using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTriggerSON : MonoBehaviour
{
    public GameObject dialogueCanvas;

    private bool playerInRange = false;

    public int kac = 0;

    public GameObject choicePanel;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && kac == 0 && dialogueCanvas.activeInHierarchy)
        {
            choicePanel.SetActive(true);
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
