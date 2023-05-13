using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguisher : MonoBehaviour
{
    public GameObject pressuredWater;

    private void Start()
    {
        //pressuredWater.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hands"))
        {
            pressuredWater.SetActive(true);
        }
        else
        {
            //pressuredWater.SetActive(false);
        }
    }
}
