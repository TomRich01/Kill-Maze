using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Logic;

namespace CoreSystem
{
public class PlayerHealth : MonoBehaviour
{

        [SerializeField] TakeDamageEvent takeDamage;
        [SerializeField] UnityEvent onDie;

        public Camera cam;
        public GameObject rainDrops;
        public GameObject bloodDrops;
        public GameObject knifeObj;
        bool isDead = false;
        bool DeathTrigger = false;
        [System.Serializable]

        
        public class TakeDamageEvent : UnityEvent<float>
        {
            
        }


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (DeathTrigger == true && isDead == true)
            {
                Dead();
            }
        }

        public bool IsDead()
        {
            return isDead;
        }

        void OnTriggerEnter(Collider weapon)
        {
            if (weapon.gameObject.CompareTag("Machete"))
            {

                Debug.Log("Player is dead");
                isDead = true;
                DeathTrigger = true;
                CapsuleCollider collider = gameObject.GetComponent<CapsuleCollider>();
                collider.direction = 2;
                FirstPersonAIO player = gameObject.GetComponent<FirstPersonAIO>();
                player.enabled = false;
                rainDrops.SetActive(false);
                bloodDrops.SetActive(true);
                knifeObj.SetActive(false);

            }
            else if (weapon.gameObject.CompareTag("AK_Bullet"))
            {

                Debug.Log("Player is dead");
                isDead = true;
                DeathTrigger = true;

            }
            else if (weapon.gameObject.CompareTag("Shell_Round"))
            {

                Debug.Log("Player is dead");
                isDead = true;
                DeathTrigger = true;

            }
            else
            {
                return;
            }
        }

        private void Dead()
        {
            if (isDead)
            {

                isDead = true;
                // gameObject.GetComponent<Animator>().SetTrigger("Die");
                Debug.Log("Trigger player death");
                
            }
        }
    }
}

