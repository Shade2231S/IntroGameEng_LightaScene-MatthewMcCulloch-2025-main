using UnityEngine;

public class Screem : MonoBehaviour
{
    //public Controller con;
    public AudioSource aud;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {             
                aud.Play();
                gameObject.SetActive(false);
        }
    }
}
