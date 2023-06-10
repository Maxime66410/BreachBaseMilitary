using UnityEngine;
using UnityEngine.SceneManagement;


public class InstantKill : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(Application.loadedLevel);

    }
}
