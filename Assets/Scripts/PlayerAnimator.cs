using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    /* Strings are a bad way to identify objects therefore 
       we use constant variables.
    */
    private const string IS_WALKING = "IsWalking";

    [SerializeField] private Player player;

    private Animator animator;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
