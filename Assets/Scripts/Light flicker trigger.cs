using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UIElements;

public class Lightflickertrigger : MonoBehaviour
{
    //public Controller con;
    public Animator ani = null;
    public List<Light> lights = new List<Light>();
    public List<GameObject> bulbson = new List<GameObject>();
    public List<GameObject> bulbsoff = new List<GameObject>();
    public PlayableDirector timelineDirector;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                timelineDirector.Play();
                gameObject.SetActive(false);
                ani.Play("Door breakback");                       
        }
    }
}
