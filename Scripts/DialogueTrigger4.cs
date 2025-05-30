using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger4 : MonoBehaviour
{
    public string[] dialogues;
    public GameObject dialogueCanvas;
    public DialogueManager2 dialogueManager2;

    private bool playerInRange = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            dialogueCanvas.SetActive(true);
            dialogueManager2.StartDialogue(dialogues);
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
