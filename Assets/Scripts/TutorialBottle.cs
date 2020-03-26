using UnityEngine;

public class TutorialBottle : MonoBehaviour
{
    public MeshCollider traliesT, anderetraliesT;
    public float tijdVoorbijT = 8;
    private float secondenT;
    private float huidigeTijdT;

    public MeshCollider colliderAanT;
    public MeshRenderer rendererAanT;
    public AudioSource Bubbles;

    // Start is called before the first frame update
    void Start()
    {
        huidigeTijdT = 0 - tijdVoorbijT;
    }

    private void Update()
    {
        secondenT += Time.deltaTime;

        //Je hebt het potion
        if (secondenT < huidigeTijdT + tijdVoorbijT)
        {
            //Potion werking
            traliesT.enabled = false;
            anderetraliesT.enabled = false;
            //Potion destroyed
            colliderAanT.enabled = false;
            rendererAanT.enabled = false;
            RenderSettings.fogDensity = 0.15f;
        }

        //Potion gaat uit
        if (secondenT > huidigeTijdT + tijdVoorbijT)
        {
            //potion uit
            traliesT.enabled = true;
            anderetraliesT.enabled = true;
            //Potion komt terug
            colliderAanT.enabled = true;
            rendererAanT.enabled = true;
            //timer resetten
            huidigeTijdT = 0-tijdVoorbijT;
            RenderSettings.fogDensity = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            huidigeTijdT = secondenT;
            Debug.Log("Tijd :" + huidigeTijdT);
            Bubbles.Play();
        }
    }
}