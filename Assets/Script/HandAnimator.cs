using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimator : MonoBehaviour
{
    private Animator animator;
    public bool IsLeftHand = false;
    private static readonly int Flex = Animator.StringToHash("Flex");
    private string gripAxis;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        gripAxis = IsLeftHand
            ? "RightTrigger"
            : "LeftTrigger";
    }

    private void Update()
    {
        float flexValue = 0;

        flexValue = Input.GetAxis(gripAxis);
        animator.SetFloat(Flex, flexValue);
    }
}