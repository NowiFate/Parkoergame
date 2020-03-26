using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialGoal : MonoBehaviour
{
    public Text pakEm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Sleutel.gotEm == true)
        {
            Invoke("gehaald",1);
        }

        if (other.tag == "Player" && Sleutel.gotEm == false)
        {
            pakEm.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        pakEm.enabled = false;
    }

    public void gehaald()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
