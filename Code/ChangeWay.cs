using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWay : MonoBehaviour
{
    int XPos;
    int ZPos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            XPos = Random.Range(-3, 50);
            ZPos = Random.Range(5, 60);
            this.gameObject.transform.position = new Vector3(XPos, 1f, ZPos);
        }
    }
}
