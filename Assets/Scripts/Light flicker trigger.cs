using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UIElements;

public class Lightflickertrigger : MonoBehaviour
{
    //public Controller con;
    public Animator ani = null;
    public AudioSource aud;
    public PlayableDirector timelineDirector;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                timelineDirector.Play();
                gameObject.SetActive(false);
                ani.Play("Door breakback");
                aud.Play();
        }
    }
}
