using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip starSFX;
    public AudioClip bombSFX;
    public AudioClip deathSFX;
    public AudioClip victorySFX;
    public AudioClip jumpSFX;

    //variable del audio source
    private AudioSource _audioSource;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    
    public void StarSound()
    {
        _audioSource.PlayOneShot(starSFX);
    }

    public void BombSound()
    {
        _audioSource.PlayOneShot(bombSFX);
    }

    public void DeathSound()
    {
        _audioSource.PlayOneShot(deathSFX);
    }

    public void VictorySound()
    {
        _audioSource.PlayOneShot(victorySFX);
    }

    public void jumpSound()
    {
        _audioSource.PlayOneShot(jumpSFX);
    }
}