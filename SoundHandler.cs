using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{
    public AudioSource someSound;

    void Start()
    {
        someSound.Play();
    }

    void PlaySound(){
        someSound.Play();
    }
}
