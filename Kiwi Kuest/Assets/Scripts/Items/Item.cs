using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    public string itemName;

    public bool isStackable;
    private int numItem;

    public enum ItemType
    {
        Equipment,
        Consumable
    }
}
