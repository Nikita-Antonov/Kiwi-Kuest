using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{

    public int curGol = 10;

    private int maxInvSpace = 40;
    public Item[] inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = new Item[maxInvSpace];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
