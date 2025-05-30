using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager3 : MonoBehaviour
{
    public Button myButton1, myButton2, myButton3, myButton4, myButton5, myButton6, myButton7, myButton8, myButton9, myButton10, myButton11;

    public int Dia = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) // YANLIS
        {
            Dia++;
            if (Dia == 1)
            {
                ChoiceManager3.instance.ilk();
                myButton1.onClick.Invoke();
            }
            else if (Dia == 2)
            {
                ChoiceManager3.instance.ikinci();
                myButton4.onClick.Invoke();
            }
            else if (Dia == 3)
            {
                ChoiceManager3.instance.ucuncu();
                myButton7.onClick.Invoke();
            }
            else if (Dia == 4)
            {
                ChoiceManager3.instance.SON();
                myButton10.onClick.Invoke();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) // DOGRU
        {
            Dia++;
            if (Dia == 1)
            {
                ChoiceManager3.instance.ilk();
                myButton2.onClick.Invoke();
            }
            else if (Dia == 2)
            {
                ChoiceManager3.instance.ikinci();
                myButton5.onClick.Invoke();
            }
            else if (Dia == 3)
            {
                ChoiceManager3.instance.ucuncu();
                myButton8.onClick.Invoke();
            }
            else if (Dia == 4)
            {
                ChoiceManager3.instance.SON();
                myButton11.onClick.Invoke();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) // DOGRU
        {
            Dia++;
            if (Dia == 1)
            {
                ChoiceManager3.instance.ilk();
                myButton3.onClick.Invoke();
            }
            else if (Dia == 2)
            {
                ChoiceManager3.instance.ikinci();
                myButton6.onClick.Invoke();
            }
            else if (Dia == 3)
            {
                ChoiceManager3.instance.ucuncu();
                myButton9.onClick.Invoke();
            }
        }
    }
}
