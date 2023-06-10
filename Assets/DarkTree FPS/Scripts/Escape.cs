using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour
{

    private bool textEnablede;
    public GameObject scripts;

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
            textEnablede = !textEnablede;

        if (textEnablede)
            scripts.SetActive(true);
        else
            scripts.SetActive(false);


    }
}