using UnityEngine;

public class PoortSwitch : MonoBehaviour
{

    public GameObject poort;
    bool isOpen =false;
    public Material voorSwitch;
    public Material naSwitch;
    private Renderer rend;
    public  int gateTransform =2;


    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = voorSwitch;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && isOpen == false)
        {
            poort.transform.position += new Vector3(0, gateTransform, 0);
            isOpen = true;
            rend.sharedMaterial = naSwitch;
        }
    }
}
