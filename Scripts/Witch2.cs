using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch2 : MonoBehaviour
{
    public GameObject Witch1, Witch22, Witch3;

    public GameObject LadyMacbeth;

    private void Update()
    {
        if (!Witch1.activeInHierarchy && !Witch22.activeInHierarchy && !Witch3.activeInHierarchy)
        {
            LadyMacbeth.SetActive(true);
        }
    }
}
