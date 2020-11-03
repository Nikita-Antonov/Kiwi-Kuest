using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Invintory/Item")]
public class SO_Item : ScriptableObject
{
    public int itemID;
    public string itemName;
    public string itemDescription;

    public bool isStackable;
    private int numItem;
    public int maxStack;

    public enum ItemType
    {
        Equipment,
        Consumable
    }
}
