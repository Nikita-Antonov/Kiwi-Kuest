using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{

    public float curTimer;
    public float maxTimer;

    public GameObject[] IdleOJB;
    public GameObject[] WalkOBJ;

    public bool isWalking;

    public int i = 0;

    public void Start()
    {
        isWalking = false;
        curTimer = maxTimer;
    }

    public void AnimationTrigger()
    {
        if (curTimer > 0)
            curTimer -= Time.fixedDeltaTime;

        if (isWalking == false)
        {
            //Idle Anim

            //IdleOJB[0].SetActive(true);

            for(int x = 0; x < WalkOBJ.Length; x++)
            {
                WalkOBJ[x].SetActive(false);
            }
           
            if(curTimer <= 0)
            {

                if (i == 0)
                {
                    IdleOJB[i].SetActive(true);
                    IdleOJB[IdleOJB.Length - 1].SetActive(false);
                    curTimer = maxTimer;
                    i++;
                }
                else
                {
                    IdleOJB[i].SetActive(true);
                    IdleOJB[i - 1].SetActive(false);
                    curTimer = maxTimer;
                    i++;
                }

                if (i == IdleOJB.Length)
                {
                    i = 0;
                    curTimer = maxTimer;
                }

            }

        }else
        {
            //Walking Anim

            for(int x = 0; x < IdleOJB.Length; x++)
            {
                IdleOJB[x].SetActive(false);
            }

            if (curTimer <= 0)
            {
                if (i == 0)
                {
                    WalkOBJ[i].SetActive(true);
                    WalkOBJ[WalkOBJ.Length - 1].SetActive(false);
                    curTimer = maxTimer;
                    i++;
                }
                else
                {
                    WalkOBJ[i].SetActive(true);
                    WalkOBJ[i - 1].SetActive(false);
                    curTimer = maxTimer;
                    i++;
                }

                if (i == WalkOBJ.Length)
                {
                    i = 0;
                    curTimer = maxTimer;
                }

                
            }
        }
    }

}
