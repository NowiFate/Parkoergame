using UnityEngine;

public class Sleutel : MonoBehaviour
{
    public static bool gotEm = false;
    public MeshRenderer sleutelke;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && gotEm == false)
        {
            gotEm = true;
            sleutelke.enabled = false;
        }
    }
}
