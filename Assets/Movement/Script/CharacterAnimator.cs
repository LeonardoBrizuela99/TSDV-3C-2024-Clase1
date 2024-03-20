using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
    public Animator animator;
    public CharacterMovement movement;
    void Update()
    {
        if (animator)
        {
            //float currentSpeed = movement.GetCurrentSpeed(); ;
            animator.SetFloat("Speed", movement.CurrentSpeed);
        }
    }
}
