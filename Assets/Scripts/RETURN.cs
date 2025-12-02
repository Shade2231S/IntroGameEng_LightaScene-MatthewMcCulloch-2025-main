using UnityEngine;
using UnityEngine.SceneManagement;
public class RETURN : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadSceneAsync(1);
    }
}
