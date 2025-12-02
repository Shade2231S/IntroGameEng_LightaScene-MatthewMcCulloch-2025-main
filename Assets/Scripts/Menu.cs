using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Qwit()
    {
        Application.Quit();
    }
}
