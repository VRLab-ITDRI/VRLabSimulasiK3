using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguisher : MonoBehaviour
{
    public GameObject pressuredWater;

    public void PinDislocated()
    {
        pressuredWater.SetActive(true);
    }
}
