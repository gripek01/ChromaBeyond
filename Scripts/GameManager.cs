using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public string hangiSahne;

    private void Start()
    {
        instance = this;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (hangiSahne == "Tiyatro1")
            {
                SceneManager.LoadScene("Sahne1");
            }
            else if (hangiSahne == "Tiyatro2")
            {
                SceneManager.LoadScene("Sahne1HamletBaba");
            }
            else if (hangiSahne == "HamletsFather")
            {
                SceneManager.LoadScene("HamletsFather");
            }
            else if (hangiSahne == "Sahne1Kolye")
            {
                SceneManager.LoadScene("Sahne1Kolye");
            }
            else if (hangiSahne == "Tiyatro2Son")
            {
                SceneManager.LoadScene("Tiyatro2Son");
            }
            else if (hangiSahne == "Sahne1")
            {
                SceneManager.LoadScene("Sahne1");
            }
            else if (hangiSahne == "Tiyatro3Kitap")
            {
                SceneManager.LoadScene("Tiyatro3Kitap");
            }
            else if (hangiSahne == "Tiyatro3Bilezik")
            {
                SceneManager.LoadScene("Tiyatro3Bilezik");
            }
            else if (hangiSahne == "SAHNE1SON")
            {
                SceneManager.LoadScene("SAHNE1SON");
            }
            
        }
    }
}
