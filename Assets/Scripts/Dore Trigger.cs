using UnityEngine;
public class DoreTrigger : MonoBehaviour
{
    public Animator ani = null;
    public bool trigger = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (trigger)
            {
                ani.Play("Door open nicley");
                gameObject.SetActive(false);
            }
        }
    }
}
