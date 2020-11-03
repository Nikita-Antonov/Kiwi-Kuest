using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class PlayerLogic : MonoBehaviour
{

    public int curGol = 10;

    public SO_Invintory inventory;

    public bool canInteract;

    public GameObject nearestNPC;

    public void FixedUpdate()
    {
        
    }

    void Interact()
    {
        if (canInteract)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                if(nearestNPC.GetComponent<NPC>().chatecterTitles == NPC.ChatecterTitles.Merchant)
                {
                    //nearestNPC.GetComponent<NPC>().cInvintory
                }
            }
        }
    }

}
