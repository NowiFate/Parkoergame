using UnityEngine;

public class BigLauch : MonoBehaviour
{
    public float highJump = 100;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(highJump * transform.up);
        }
    }
}
