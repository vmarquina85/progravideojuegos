using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CombatManager : MonoBehaviour
{
    public static CombatManager instance;

 
    public bool hasSword;
    public Animator animator;

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (hasSword)
        {
            animator.SetBool("HasSword", true);
        }
        else
        {
            animator.SetBool("HasSword", false);
        }

        if (Input.GetMouseButtonDown(0) && hasSword)
        {
            animator.SetBool("IsJumping", false);
            animator.SetTrigger("SwordAttack1");

        }
   }

  



}