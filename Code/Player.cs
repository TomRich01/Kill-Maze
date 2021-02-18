using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Logic
{
    public class Player : MonoBehaviour
    {
       
        FirstPersonAIO moveContr;
        GameObject currentWeapon;
        public GameObject knife;
        public GameObject gun;
        public GameObject t_knife;
        public bool isHiding = false;
        void Start()
        {
            
            moveContr = GetComponent<FirstPersonAIO>();
        }

        public void movement()
        {
          
            

        }



        void Update()
        {
           
        }




    }
}
        // Start is called before the first frame update
   
    // Update is called once per frame
   

