using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger3 : MonoBehaviour
{
    public static DialogueTrigger3 instance;

    public string[] dialogues;
    public GameObject dialogueCanvas;
    public DialogueManager dialogueManager;

    private bool playerInRange = false;

    public int kac = 0;

    public GameObject choicePanel;


    private GameObject player;
    private SUPERCharacterAIO playerController;
    private void Start()
    {
        instance = this;
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<SUPERCharacterAIO>();
    }
    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && kac == 0)
        {

            dialogueCanvas.SetActive(true);
            dialogueManager.StartDialogue(dialogues);
            kac++;
        }
        else if (playerInRange && Input.GetKeyDown(KeyCode.E) && kac != 0 && !dialogueCanvas.activeInHierarchy)
        {
            //playerController.PausePlayer(PauseModes.FreezeInPlace);  // Hareketi durdur 
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

    public void KarakterHareketDevam()
    {
        //playerController.UnpausePlayer(); // Hareketi tekrar aç
    }
}
