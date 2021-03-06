﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    //Charecter Name
    [Header("Name and Title")]
    public string cName;

    //Enum to handle the diffrent types of NPC'
    public ChatecterTitles chatecterTitles;
    public enum ChatecterTitles
    {
        NPC,
        Merchant,
        questGiver
    }
    [Space]

    //Refrences to UI Text
    [Header("Gameobject Refrences")]
    public Text nameText;
    public Text titleText;
    [Space]

    //Invintory Reffrence
    [Header("NPC Invintory")]
    public SO_Invintory cInvintory;

    //Refrence to the Sphere Collider used for handling intecactrions
    //If the player is within the collider he can talk to the NPC
    public SphereCollider interactionCollider;

    //Declaring the Name, Title, and getting refference to the Sphere Collider
    void Start()
    {   
        nameText.text = cName;
        titleText.text = chatecterTitles.ToString();
        interactionCollider = GetComponent<SphereCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + "Is in the range of " + cName + ", The " + titleText);
        other.gameObject.GetComponent<PlayerLogic>().canInteract = true;
        other.gameObject.GetComponent<PlayerLogic>().nearestNPC = this.gameObject;
    }

    void Merchant()
    {

    }

    
}
