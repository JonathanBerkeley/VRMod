using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainAnimator : MonoBehaviour
{
    public Animator anim;
    private bool state = true; // False = down
    
    public void Clicked()
    {
        if (state)
        {
            anim.Play("Base Layer.CurtainAnimation");
            state = false;
        }
        else
        {
            anim.Play("Base Layer.CurtainReverse");
            state = true;
        }
    }
}
