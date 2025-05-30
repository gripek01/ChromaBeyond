using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public static ButtonManager instance;

    public Button myButton, myButton2, myButton3, myButton4, myButton5, myButton6, tekrarDeneButton;

    public GameObject MentalIns, MentalBal;

    public int Dia=0;

    public int yanlisSecim;

    public GameObject losePanel;

    private void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) // Klavyeden 1 tuþuna basýldýðýnda
        {
            yanlisSecim++;
            Dia++;
            if (Dia == 1)
            {
                myButton.onClick.Invoke();
                ChoiceManager.instance.ilkSecenekler();
                MentalIns.SetActive(true);
            }
            else if (Dia == 2)
            {
                myButton3.onClick.Invoke();
                ChoiceManager.instance.ikinciSecenekler();
                MentalIns.SetActive(true);
            }
            else if(Dia == 3)
            {
                myButton5.onClick.Invoke();
                ChoiceManager.instance.sonSecenekler();
                MentalIns.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) // Klavyeden 1 tuþuna basýldýðýnda
        {
            Dia++;
            if (Dia == 1)
            {
                myButton2.onClick.Invoke(); // Butonun click olayýný tetikle
                ChoiceManager.instance.ilkSecenekler();
                MentalBal.SetActive(true);
            }
            else if (Dia == 2)
            {
                myButton4.onClick.Invoke(); // Butonun click olayýný tetikle
                ChoiceManager.instance.ikinciSecenekler();
                MentalBal.SetActive(true);
            }
            else if (Dia == 3)
            {
                myButton6.onClick.Invoke(); // Butonun click olayýný tetikle
                ChoiceManager.instance.sonSecenekler();
                MentalBal.SetActive(true);
            }
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
        SceneManager.LoadScene("Tiyatro2");
    }
}
