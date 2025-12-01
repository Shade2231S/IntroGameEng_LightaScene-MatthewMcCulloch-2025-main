using System.Collections.Generic;
using UnityEngine;
public class LightTrigger : MonoBehaviour
{
    public List<Light> lights = new List<Light>();
    public List<GameObject> bulbson = new List<GameObject>();
    public List<GameObject> bulbsoff = new List<GameObject>();
    public bool trigger = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (trigger)
            {
                foreach (Light light in lights)
                {
                    light.enabled = false;
                }
                foreach (GameObject bulbson in bulbson)
                {
                    bulbson.active = false;
                }
                foreach (GameObject bulbsoff in bulbsoff)
                {
                    bulbsoff.active = true;
                }
            }
        }
    }
}
