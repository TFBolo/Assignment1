using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect1 : MonoBehaviour
{
    public void Switch1 ()
    {
        SceneManager.LoadScene(1);
    }

    public void Switch2()
    {
        SceneManager.LoadScene(2);
    }

    public void Switch3()
    {
        SceneManager.LoadScene(3);
    }
}
