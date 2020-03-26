using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class AantalMunten : MonoBehaviour
{
    public GameObject[] AllCoins;
    public UnityEvent Gehaald;
    public Text muntenText;
    private int points = 0;
    public AudioSource CoinSound;

    private void Start()
    {
        muntenText.text = "Munten: " + points.ToString() + "/5";

        for (int i = 0; i < AllCoins.Length; i++)
        {
            AllCoins[i].SetActive(true);
        }

        AllCoins[AllCoins.Length - 1].SetActive(false);
    }

    public void CoinCollected()
    {
        points++;
        CoinSound.Play();
        if (points == AllCoins.Length-1)
        {
            AllCoins[AllCoins.Length - 1].SetActive(true);
        }
        muntenText.text = "Munten: " + points.ToString() + "/5";

        //winconditie
        if (points == AllCoins.Length)
        {
            Gehaald.Invoke();
        }
    }
}
