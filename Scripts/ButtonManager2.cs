using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager2 : MonoBehaviour
{

    public Button myButton, myButton2, tekrarDeneButton;

    public GameObject losePanel, sahne1SonPanel, CanvasPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) // YANLIS
        {
            CanvasPanel.SetActive(false);
            myButton.onClick.Invoke();
            losePanel.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) // DOGRU
        {
            CanvasPanel.SetActive(false);
            sahne1SonPanel.SetActive(true);
            myButton2.onClick.Invoke();
        }
        if (losePanel.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                tekrarDeneButton.onClick.Invoke();
            }
        }
    }

    public void TekrarOyna()
    {
        SceneManager.LoadScene("Tiyatro3Baslangic");
    }
}
