using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renkler : MonoBehaviour
{
    public GameObject[] Tiyatro1Renk, Tiyatro2Renk;
    public int yeniLayer; // Unity'den layer ID'yi atamak için

    private void Start()
    {
        print(PlayerPrefs.GetInt("Tiyatro1"));
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("Tiyatro1") == 1)
        {
            foreach (var item in Tiyatro1Renk)
            {
                item.layer = yeniLayer;
            }
        }
        if (PlayerPrefs.GetInt("Tiyatro2") == 1)
        {
            foreach (var item in Tiyatro2Renk)
            {
                item.layer = yeniLayer;
            }
        }
    }
}