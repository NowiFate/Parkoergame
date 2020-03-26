using UnityEngine;

public class Jailed : MonoBehaviour
{
    public GameObject anderePoort;
    bool hekvalt = false;
    public AudioSource hekGeluid;
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && hekvalt == false)
        {
            hekvalt = true;
            anderePoort.transform.position += new Vector3(0, -5, 0);
            hekGeluid.Play();
        }
    }
}
