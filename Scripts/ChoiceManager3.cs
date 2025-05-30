using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class ChoiceManager3 : MonoBehaviour
{
    public static ChoiceManager3 instance;

    public GameObject choicePanel, Text1, Text2, Text3, Text4, Text5, Text6, Text7;

    public Button Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7, Opt8, Opt9, Opt10, Opt11;

    public GameObject PANEL;

    public GameObject Villain;

    public Volume volume;
    private ColorAdjustments colorAdjustments;
    private void Start()
    {
        instance = this;
    }
    void Update()
    {
        if (choicePanel.activeInHierarchy)
        {
            if (Text1.activeInHierarchy && Input.GetKeyDown(KeyCode.F))
            {
                Text1.SetActive(false);
                Text2.SetActive(true);
            }
            else if (Text2.activeInHierarchy && Input.GetKeyDown(KeyCode.F))
            {
                Text2.SetActive(false);
                Text3.SetActive(true);
                Opt1.gameObject.SetActive(true);
                Opt2.gameObject.SetActive(true);
                Opt3.gameObject.SetActive(true);
            }
            else if (Text3.activeInHierarchy && Input.GetKeyDown(KeyCode.F))
            {
                Text3.SetActive(false);
                Opt1.gameObject.SetActive(false);
                Opt2.gameObject.SetActive(false);
                Opt3.gameObject.SetActive(false);


                Text4.SetActive(true);
                Opt4.gameObject.SetActive(true);
                Opt5.gameObject.SetActive(true);
                Opt6.gameObject.SetActive(true);
            }
            else if (Text4.activeInHierarchy && Input.GetKeyDown(KeyCode.F))
            {
                Text4.SetActive(false);
                Opt4.gameObject.SetActive(false);
                Opt5.gameObject.SetActive(false);
                Opt6.gameObject.SetActive(false);


                Text5.SetActive(true);
                Opt7.gameObject.SetActive(true);
                Opt8.gameObject.SetActive(true);
                Opt9.gameObject.SetActive(true);
            }
            else if (Text5.activeInHierarchy && Input.GetKeyDown(KeyCode.F))
            {
                Text5.SetActive(false);
                Opt7.gameObject.SetActive(false);
                Opt8.gameObject.SetActive(false);
                Opt9.gameObject.SetActive(false);

                Text6.SetActive(true);
                Opt10.gameObject.SetActive(true);
                Opt11.gameObject.SetActive(true);
            }
        }
    }

    public void ilk()
    {
        Text3.SetActive(false);
        Opt1.gameObject.SetActive(false);
        Opt2.gameObject.SetActive(false);
        Opt3.gameObject.SetActive(false);


        Text4.SetActive(true);
        Opt4.gameObject.SetActive(true);
        Opt5.gameObject.SetActive(true);
        Opt6.gameObject.SetActive(true);
    }

    public void ikinci()
    {
        Text4.SetActive(false);
        Opt4.gameObject.SetActive(false);
        Opt5.gameObject.SetActive(false);
        Opt6.gameObject.SetActive(false);


        Text5.SetActive(true);
        Opt7.gameObject.SetActive(true);
        Opt8.gameObject.SetActive(true);
        Opt9.gameObject.SetActive(true);
    }

    public void ucuncu()
    {
        Text5.SetActive(false);
        Opt7.gameObject.SetActive(false);
        Opt8.gameObject.SetActive(false);
        Opt9.gameObject.SetActive(false);

        Text6.SetActive(true);
        Opt10.gameObject.SetActive(true);
        Opt11.gameObject.SetActive(true);
    }

    public void SON()
    {
        PANEL.SetActive(false);
        if (volume.profile.TryGet(out colorAdjustments))
        {
            colorAdjustments.saturation.value = 100f;
        }
        Villain.SetActive(false);
    }
}
