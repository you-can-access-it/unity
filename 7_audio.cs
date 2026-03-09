using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class audio : MonoBehaviour
{
    private AudioSource audiosource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        if(audiosource == null)
        {
            Debug.LogError("Audio Compoenent not found");
            return;
        }
        audiosource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            audiosource.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
         audiosource.Stop();   
        }
        
    }
}
