using UnityEngine;
using UnityEngine.UI;
using System;

public class Tijdsduur : MonoBehaviour
{
    public Text tijdtekst;
    private TimeSpan ElapsedTime;
    public GameObject eindSchermUI;
    public Text eindScore;

    private void Start()
    {
        eindSchermUI.SetActive(false);
        ElapsedTime = new TimeSpan(0);
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime = ElapsedTime.Add(TimeSpan.FromSeconds(Time.deltaTime));
        tijdtekst.text = string.Format("{0:mm\\:ss}", ElapsedTime);
    }

    private void hetScherm()
    {
        eindSchermUI.SetActive(true);
    }

    public void GameWon()
    {
        eindScore.text = string.Format("{0:mm\\:ss}", ElapsedTime);
        Invoke("hetScherm", 1);
    }
}
