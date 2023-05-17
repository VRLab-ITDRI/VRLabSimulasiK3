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

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        audioSource.Play();
    //    }
    //    else
    //    {
    //        audioSource.Stop();
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
#if UNITY_EDITOR
            Debug.Log("KELUAR AH AH!!");
#endif
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            audioSource.Stop();
        }
    }
    #endregion
}
