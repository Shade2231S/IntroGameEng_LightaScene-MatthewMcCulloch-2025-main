using UnityEngine;

public class Physics : MonoBehaviour
{
    public float forcepush = 15f;
    public Vector3 pushback = Vector3.back;
    public Rigidbody rid1;
    public Rigidbody rid2;
    public Rigidbody rid3;
    public Rigidbody rid4;
    public Rigidbody rid5;
    public Rigidbody rid6;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rid1.AddForce(transform.TransformDirection(pushback) * forcepush, ForceMode.Impulse);
            rid2.AddForce(transform.TransformDirection(pushback) * forcepush, ForceMode.Impulse);
            rid3.AddForce(transform.TransformDirection(pushback) * forcepush, ForceMode.Impulse);
            rid4.AddForce(transform.TransformDirection(pushback) * forcepush, ForceMode.Impulse);
            rid5.AddForce(transform.TransformDirection(pushback) * forcepush, ForceMode.Impulse);
            rid6.AddForce(transform.TransformDirection(pushback) * forcepush, ForceMode.Impulse);
        }
    }
}
