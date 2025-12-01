using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class LightFlikerTrigger : MonoBehaviour
{
    public Animator ani = null;
    public List<Light> lights = new List<Light>();
    public bool trigger = false;
    public bool flick = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (trigger)
            {
                ani.Play("Door breakback");
                gameObject.SetActive(false);
                if (flick == true)
                {
                    StartCoroutine(flicker());
                    flick = false;
                }
            }
        }
    }
    IEnumerator flicker()
    {
        yield return new WaitForSeconds(0.5f);
        foreach (Light light in lights) { light.enabled = false; }
        yield return new WaitForSeconds(0.5f);
        foreach (Light light in lights) { light.enabled = true; }
        flick = true;
    }
}
