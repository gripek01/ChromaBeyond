using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{
    public static ChoiceManager instance;

    public GameObject choicePanel, HamletText1, HamletText2, HamletText3;

    public Button Opt1, Opt2, Opt3, Opt4, Opt5, Opt6;

    public GameObject LosePanel;

    public GameObject Ophelia;
    private void Start()
    {
        instance = this;
    }
    void Update()
    {
        if (choicePanel.activeInHierarchy)
        {
            if (HamletText1.activeInHierarchy && Input.GetKeyDown(KeyCode.F))
            {
                HamletText1.SetActive(false);
                Opt1.gameObject.SetActive(true);
                Opt2.gameObject.SetActive(true);
            }
            else if(HamletText2.activeInHierarchy && Input.GetKeyDown(KeyCode.F))
            {
                HamletText2.SetActive(false);
                Opt3.gameObject.SetActive(true);
                Opt4.gameObject.SetActive(true);
            }
            else if (HamletText3.activeInHierarchy && Input.GetKeyDown(KeyCode.F))
            {
                HamletText3.SetActive(false);
                Opt5.gameObject.SetActive(true);
                Opt6.gameObject.SetActive(true);
            }
        }        
    }

    public void ilkSecenekler()
    {
        Opt1.gameObject.SetActive(false);
        Opt2.gameObject.SetActive(false);
        HamletText2.SetActive(true);
    }
    public void ikinciSecenekler()
    {
        Opt3.gameObject.SetActive(false);
        Opt4.gameObject.SetActive(false);
        HamletText3.SetActive(true);
    }
    public void sonSecenekler()
    {
        if (ButtonManager.instance.yanlisSecim != 0)
        {
            choicePanel.SetActive(false);
            LosePanel.SetActive(true);
        }
        else
        {
            choicePanel.SetActive(false);
            DialogueTrigger3.instance.KarakterHareketDevam();
            Ophelia.SetActive(true);
        }
    }
}
