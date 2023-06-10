using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public static Win Instance { get; private set; }

    public DarkTreeFPS.NPC Npc;

    public int WinLimit = 0;

    [Header("GameManager Settings")]
    public GameObject[] NPC;

    public GameObject GroupNPC;

    // Start is called before the first frame update
    void Start()
    {
        Npc = Npc.GetComponent<DarkTreeFPS.NPC>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(DarkTreeFPS.NPC < WinLimit)
        {

        }
    }

    public void Death()
    {

    }
}
