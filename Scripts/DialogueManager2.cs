using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager2 : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public Button nextButton;

    private string[] currentDialogues;
    private int dialogueIndex = 0;

    private GameObject player;
    private SUPERCharacterAIO playerController;

    public GameObject AnaSahneText;
    void Start()
    {
        //nextButton.onClick.AddListener(NextDialogue);
        gameObject.SetActive(false);

        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<SUPERCharacterAIO>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            NextDialogue();
        }
    }

    public void StartDialogue(string[] dialogues)
    {
        currentDialogues = dialogues;
        dialogueIndex = 0;

        //playerController.PausePlayer(PauseModes.FreezeInPlace);  // Hareketi durdur 
        ShowDialogue();
    }

    void ShowDialogue()
    {
        if (dialogueIndex < currentDialogues.Length)
        {
            dialogueText.text = currentDialogues[dialogueIndex];
        }
        else
        {
            EndDialogue();
            AnaSahneText.SetActive(true);
        }
    }

    public void NextDialogue()
    {
        dialogueIndex++;
        ShowDialogue();
    }

    void EndDialogue()
    {
        dialogueText.text = "";
        //playerController.UnpausePlayer(); // Hareketi tekrar aç
        gameObject.SetActive(false);
        PlayerPrefs.SetInt("Tiyatro2", 1);
    }
}
