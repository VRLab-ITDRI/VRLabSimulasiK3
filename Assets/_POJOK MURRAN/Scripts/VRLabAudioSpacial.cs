using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(AudioSource))]
public class VRLabAudioSpacial : MonoBehaviour
{
    #region _VARIABLE
    private AudioSource audioSource;
    #endregion

    #region _UNITY FUNCTION
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (gameObject.CompareTag("Player"))
        {
#if UNITY_EDITOR
            audioSource.Play();
#endif
        }
        else
        {
            audioSource.Stop();
        }
    }
    #endregion
}
