using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioUIButton : MonoBehaviour
{

    private Toggle audioUIButton;

    void Awake()
    {

        audioUIButton = GetComponent<Toggle>();
        isMuted = FindObjectOfType<DontDestroyAudioSource>().isMuted;

    }

    public bool isMuted
    {

        set { audioUIButton.isOn = value; }
        get { return audioUIButton.isOn; }

    }

}
