using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField, Range(0f, 1f)] private float currentIntensity = 1.0f;
    private float[] startIntensities = new float[0];

    [SerializeField] private ParticleSystem[] firePS = new ParticleSystem[0];

    public float amount = 0.5f;

    //public ParticleSystem part;
    public List<ParticleCollisionEvent> collisionEvents;

    private void Start()
    {
        startIntensities = new float[firePS.Length];

        for (int i = 0; i < firePS.Length; i++)
        {
            startIntensities[i] = firePS[i].emission.rateOverTime.constant;
        }
    }

    private void Update()
    {
        ChangeIntensity();
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Water"))
        {
            Debug.LogWarning("Airnya kena Api WOY!");
            TryExtinguish();
        }
    }

    public void TryExtinguish()
    {
        currentIntensity -= amount;
    }

    private void ChangeIntensity()
    {
        for (int i = 0; i < firePS.Length; i++)
        {
            var emission = firePS[i].emission;
            emission.rateOverTime = currentIntensity * startIntensities[i];
        }
        
    }
}
