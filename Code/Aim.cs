using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public GameObject knifeDisplay;
    public Animator anim;
    public GameObject spawner;
    public GameObject knifeOBJ;
    public int countdown = 3;
    public int knifeCount;

    private Rigidbody rigidbodyKnife;

   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        knifeCount = FindObjectsOfType<Thrown>().Length;
        if (Input.GetMouseButton(1))
        {
            anim.SetBool("Aiming", true);
            knifeDisplay.SetActive(true);

            if (Input.GetMouseButton(0))
            {

                if (knifeCount == 0)
                {

                    knifeDisplay.SetActive(false);
                    SpawnKnife();
                }
                if (knifeCount >= 1)
                {
                    knifeDisplay.SetActive(false);
                }
                    
 
            }
        }
       
        if (!Input.GetMouseButton(1))
        {
            
            anim.SetBool("Aiming", false);
            knifeDisplay.SetActive(true);

        }
    }
    
   void SpawnKnife()
    {
        for (int i = 0; i < 1; i++)
        {
            Instantiate(knifeOBJ, spawner.transform.position, transform.rotation);
        }
       
        
        
    }

   

  
}
