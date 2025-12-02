using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.Audio;
public class DoreTrigger : MonoBehaviour
{
    //public Controller con;
    public Animator ani = null;
    public AudioSource aud; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            ani.Play("Door open nicley");
            gameObject.SetActive(false);
            aud.Play();
        }
    }
}