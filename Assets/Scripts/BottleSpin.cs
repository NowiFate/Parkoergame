using UnityEngine;

public class BottleSpin : MonoBehaviour
{
    public MeshCollider tralies, anderetralies;
    public float tijdVoorbij = 8;
    private float seconden;
    private float huidigeTijd;

    public MeshCollider colliderAan;
    public MeshRenderer rendererAan;
    public AudioSource Bubbles;

    // Start is called before the first frame update
    void Start()
    {
        huidigeTijd = 0 - tijdVoorbij;
    }

    private void Update()
    {
        seconden += Time.deltaTime;

        //Je hebt het potion
        if (seconden < huidigeTijd + tijdVoorbij)
        {
            //Potion werking
            tralies.enabled = false;
            anderetralies.enabled = false;
            //Potion destroyed
            colliderAan.enabled = false;
            rendererAan.enabled = false;
            RenderSettings.fogDensity = 0.08f;
        }

        //Potion gaat uit
        if (seconden > huidigeTijd + tijdVoorbij)
        {
            //potion uit
            tralies.enabled = true;
            anderetralies.enabled = true;
            //Potion komt terug
            colliderAan.enabled = true;
            rendererAan.enabled = true;
            //timer resetten
            huidigeTijd = 0-tijdVoorbij;
            RenderSettings.fogDensity = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            huidigeTijd = seconden;
            Debug.Log("Tijd :" + huidigeTijd);
            Bubbles.Play();
        }
    }
}