using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontDestroyAudioSource : MonoBehaviour
{

    [HideInInspector] public bool isMuted;

    void Awake()
    {
        
        handleAudio();

    }

    void Start()
    {

        isMuted = false;

    }

    void Update()
    {

        if (!(FindObjectsOfType(GetType()).Length > 1) && FindObjectOfType<AudioUIButton>() != null)
        {

            if (FindObjectOfType<AudioUIButton>().isMuted)
            {

                AudioListener.volume = 0;
                isMuted = true;

            }
            else
            {

                AudioListener.volume = 1;
                isMuted = false;

            }

        }

    }

    private void handleAudio()
    {
        
        if (FindObjectsOfType(GetType()).Length > 1)
        {

            Destroy(gameObject);

        }
        else
        {

            DontDestroyOnLoad(gameObject);

        }

    }

}
