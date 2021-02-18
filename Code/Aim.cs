using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public GameObject knife;
    public Animator anim;

   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            anim.SetBool("Aiming", true);
            anim.SetBool("Throw", false);

            if (Input.GetMouseButton(0))
            {
                anim.SetBool("Throw", true);
              //  RaycastHit checkCover;
               // int range = 5;
                // create the ray to use
                // Ray ray = new Ray(transform.position, GameObject.FindGameObjectWithTag("Enemy").transform.position - transform.position);
                //casting a ray against the player
               /* if (Physics.Raycast(ray, out checkCover, range))
                {
                    //we are here if the ray hit a collider
                    //now to check if that collider is the player
                    if (checkCover.collider.gameObject.CompareTag("Enemy"))
                    {
                        checkCover.collider.gameObject.GetComponent<Enemy_Move>().State = Enemy_Move.CURRENT_STATE.Dead;
                       // GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy_Move>().State = Enemy_Move.CURRENT_STATE.Dead;
                    }
                } */

            }
        }
       
        if (!Input.GetMouseButton(1))
        {
            anim.SetBool("Aiming", false);
            anim.SetBool("Throw", false);
        }
    }
    void FixedUpdate()
    {
       
    }

  
}
