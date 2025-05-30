using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiseManager2 : MonoBehaviour
{

    public GameObject choicePanel, Text1, Text2, Text3, Text4, Text5;

    public Button Opt1, Opt2;

    //public GameObject LosePanel;
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
            }
            else if (Text3.activeInHierarchy && Input.GetKeyDown(KeyCode.F))
            {
                Text3.SetActive(false);
                Text4.SetActive(true);
            }
            else if (Text4.activeInHierarchy && Input.GetKeyDown(KeyCode.F))
            {
                Text4.SetActive(false);
                Text5.SetActive(true);
            }
            else if (Text5.activeInHierarchy && Input.GetKeyDown(KeyCode.F))
            {
                Text5.SetActive(false);
                Opt1.gameObject.SetActive(true);
                Opt2.gameObject.SetActive(true);
            }
        }
    }
}
