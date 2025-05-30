using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
{
    public GameObject Witch1, Witch2, Witch3;

    public GameObject Sahne1Text, fisilti;

    private void Update()
    {
        if(!Witch1.activeInHierarchy && !Witch2.activeInHierarchy && !Witch3.activeInHierarchy)
        {
            Sahne1Text.SetActive(true);
            fisilti.SetActive(true);
        }
    }
}
