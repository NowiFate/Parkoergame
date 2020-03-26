using UnityEngine;
using UnityEngine.SceneManagement;

public class Volgende : MonoBehaviour
{
    public void LetsGo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
