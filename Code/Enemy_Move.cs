using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Move : MonoBehaviour
{
    public Transform guardPost;
    public Transform player;
    NavMeshAgent agent;
    Animator anim;

    public GetInfo gameManager;

   [SerializeField] public CURRENT_STATE State = CURRENT_STATE.Patrol;
   
    [SerializeField] float detectionRadius;
    [SerializeField] float engageDistance;
    [SerializeField] float attackDistance;
    



    public enum CURRENT_STATE
    {
        Patrol = 0,
        Engage = 1,
        Dead = 2
    }


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
        
        // agent.updatePosition = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (State == CURRENT_STATE.Patrol)
        {
            agent.isStopped = false;
            agent.destination = guardPost.position;
            anim.SetFloat("Move", (float)0.5);
            if (Vector3.Distance(player.position, transform.position) <= detectionRadius)
            {
                State = CURRENT_STATE.Engage;
                if (gameManager.isHiding == true)
                {
                    State = CURRENT_STATE.Patrol;
                }
            }

           
           

        }
        if (State == CURRENT_STATE.Engage)
        {
           
                agent.isStopped = false;
                agent.destination = player.position;
            anim.SetFloat("Move", (float)0.5);
            if (Vector3.Distance(player.position, transform.position) <= engageDistance)
            {
                anim.SetFloat("Move", 1);
                
                if (Vector3.Distance(player.position, transform.position) <= attackDistance)
                {
                    anim.SetFloat("Move", 0);
                    anim.SetTrigger("Attack");

                    
                }

               

            }

                if (Vector3.Distance(player.position, transform.position) >= detectionRadius)
            {
                State = CURRENT_STATE.Patrol;
            }



        }
        if (State == CURRENT_STATE.Dead)
        {
            
            agent.isStopped = true;
            anim.SetBool("Die", true);
            Destroy(gameObject, 2);
        }

        
        
    }




    private void Attack()
    {

    }



    void OnAnimatorMove()
    {
        // Update position to agent position
        transform.position = agent.nextPosition;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, engageDistance);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, attackDistance);
       
    }
}
