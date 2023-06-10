using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Quality : MonoBehaviour
{

    public Canvas Graphic;
    public Button Low;
    public Button Medium;
    public Button High;
    public Button VeryHight;

    void Start()
    {
        Graphic = Graphic.GetComponent<Canvas>();
        Low = Low.GetComponent<Button>();
        Medium = Medium.GetComponent<Button>();
        High = High.GetComponent<Button>();
        VeryHight = VeryHight.GetComponent<Button>();
        Graphic.enabled = false;

    }
    public void lowww()
    {
        QualitySettings.SetQualityLevel(0);
    }
    public void meddd()
    {
        QualitySettings.SetQualityLevel(1);
    }
    public void highhh()
    {
        QualitySettings.SetQualityLevel(2);
    }
    public void veryhighhh()
    {
        QualitySettings.SetQualityLevel(3);
    }

}