using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNOAScript : MonoBehaviour
{

    public GameObject Player;
    private Transform playerPos;
    //private Vector2 currentPos;
    public float seekDistance;
    public float attackDistance;
    public float speedEnemy;
    private float currentDistance;
    private Animator enemyAnimator;
    private SpriteRenderer srEnemy;

    //rate de ataque de enemigo Bee


    public float rate = 1f;
    private float counter = 0f;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = Player.GetComponent<Transform>(); //posicion del jugador
        //currentPos = GetComponent<Transform>().position; //posicion del enemigo
        enemyAnimator = GetComponent<Animator>();//animador del enemigo
        srEnemy = GetComponent<SpriteRenderer>();// renderer del enemigo
        

    }

    // Update is called once per frame
    void Update()
    {
        currentDistance = Vector2.Distance(transform.position, playerPos.position);
        if (Vector2.Distance(transform.position,playerPos.position) < seekDistance  && Vector2.Distance(transform.position, playerPos.position)> attackDistance) // si la distancia entre ambos enemigo y player es menor que 5
        {

            transform.position = Vector2.MoveTowards(transform.position, playerPos.position , speedEnemy * Time.deltaTime);
            if (transform.position.x>playerPos.position.x)
            {
                srEnemy.flipX = true;
            }
            else if (transform.position.x < playerPos.position.x)
            {   
                srEnemy.flipX = false;
            }
            enemyAnimator.SetBool("Run", true);
        }
        else if (Vector2.Distance(transform.position, playerPos.position) < attackDistance && Time.time > counter)
        {
            enemyAnimator.SetBool("Run", false);
       
            counter = Time.time + rate;
        }else
        {
            enemyAnimator.SetBool("Run", false);
        }
        //else
        //{
        //    if (Vector2.Distance(transform.position,currentPos)<0)
        //    {
        //        enemyAnimator.SetBool("Run", false);
        //    }
        //    else
        //    {
        //        transform.position = Vector2.MoveTowards(transform.position, currentPos, speedEnemy * Time.deltaTime);
        //        enemyAnimator.SetBool("Run", true);
        //    }
        //}
    }
}
