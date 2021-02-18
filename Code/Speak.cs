using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speak : MonoBehaviour
{
   
    private AudioSource audioSource;
    [Space(10)] // 10 pixels of spacing here.
    public AudioClip[] Taunt;
    private AudioClip TauntClip;
    [Space(10)] // 10 pixels of spacing here.
    public int waitSec;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();

        StartCoroutine("WaitFiveSeconds");

    }


    IEnumerator WaitFiveSeconds()
    {
        // Pause the game
        PlayRandomTaunt();
        audioSource.Play();

        yield return new WaitForSecondsRealtime(waitSec);

         StartCoroutine("WaitFiveSeconds");
    }



        public void PlayRandomTaunt()
    {
        int index = Random.Range(0, Taunt.Length);
        TauntClip = Taunt[index];
        audioSource.clip = TauntClip;

    }

    private void FixedUpdate()
    {
        
    }

}
