using SUPERCharacter;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public string[] dialogues; // Inspector üzerinden yazýlacak
    public GameObject dialogueCanvas; // UI Canvas
    public DialogueManager dialogueManager; // Manager Script

    private bool playerInRange = false;

    public GameObject book, Romeo;

    public int Sayac;
    private void Start()
    {
        Sayac = 0;
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            Sayac++;
            if (Sayac == 1)
            {
                book.SetActive(true);
            }

            if (Mektup.instance.mektupAlindi)
            {
                Romeo.SetActive(true);
                Mektup.instance.zamanlayiciCanvas.SetActive(false);
            }
            dialogueCanvas.SetActive(true);
            dialogueManager.StartDialogue(dialogues);
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
