using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInfo : MonoBehaviour
{
    public HidingSpot[] hidingSpot;
    public bool isHiding;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < hidingSpot.Length; i++)
        {
            if (hidingSpot[i].GetComponent<HidingSpot>())
            {
                isHiding = hidingSpot[i].player.isHiding;
            }
        }
    }
}
