using UnityEngine;
using System.Collections;

public class SetQualityLevels : MonoBehaviour
{
    void Update()
    {
        switch (Input.inputString)
        {
            case "1":
                QualitySettings.SetQualityLevel(0, true);
                Debug.Log("Quality settings set to 'Low'");
                break;
            case "2":
                QualitySettings.SetQualityLevel(1, true);
                Debug.Log("Quality settings set to 'Medium'");
                break;
            case "3":
                QualitySettings.SetQualityLevel(2, true);
                Debug.Log("Quality settings set to 'Hight'");
                break;
            case "4":
                QualitySettings.SetQualityLevel(3, true);
                Debug.Log("Quality settings set to 'Very Hight'");
                break;
            default:
                Debug.Log("Button does not change the quality settings!");
                break;
        }
    }
}