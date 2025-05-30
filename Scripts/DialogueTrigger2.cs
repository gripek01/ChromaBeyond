using SUPERCharacter;
using UnityEngine;

public class DialogueTrigger2 : MonoBehaviour
{
    public string[] dialogues;
    public GameObject dialogueCanvas;
    public DialogueManager dialogueManager;

    private bool playerInRange = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            dialogueCanvas.SetActive(true);
            dialogueManager.StartDialogue(dialogues);
            PlayerPrefs.SetInt("Tiyatro1", 1);
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
