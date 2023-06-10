using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesacTextCommand : MonoBehaviour
{

    private bool textEnabled;
    public GameObject script;

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.F1))
            textEnabled = !textEnabled;

        if (textEnabled)
            script.SetActive(false);
        else
            script.SetActive(true);


    }
}