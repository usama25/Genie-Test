using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator characterAnimator;

    public void Idle()
    {
        characterAnimator.SetTrigger("idle");
    }
    
    public void Run()
    {
        characterAnimator.SetTrigger("run");
    }
    
    public void Wave()
    {
        characterAnimator.SetTrigger("wave");
    }
    
    public void Pickup()
    {
        characterAnimator.SetTrigger("pickup");
    }
    
    public void Jump()
    {
        characterAnimator.SetTrigger("jump");
    }
}
