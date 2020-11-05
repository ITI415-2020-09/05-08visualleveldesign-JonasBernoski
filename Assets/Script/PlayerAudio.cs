using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerAudio : MonoBehaviour
{
    public AudioClip Footstep01;

    public AudioSource Step;

    public AudioMixerSnapshot IdleSnapshot;
    public AudioMixerSnapshot SecondSnapshot;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Step.PlayOneShot(Footstep01);
        }
        if (other.CompareTag("The Zone"))
        {
            SecondSnapshot.TransitionTo(0.5f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Step.PlayOneShot(Footstep01);
        }
        if (other.CompareTag("The Zone"))
        {
            IdleSnapshot.TransitionTo(0.5f);
        }
    }

}
