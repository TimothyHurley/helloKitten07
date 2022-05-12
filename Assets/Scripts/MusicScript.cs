using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    [SerializeField]
    private AudioClip music;
    [SerializeField]
    private AudioSource soundSource;

    void Start()
    {
        soundSource.clip = music;
        soundSource.loop = true;
        soundSource.Play();
    }
}
