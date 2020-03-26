using UnityEngine;
using UnityEngine.Events;

public class CoinScript : MonoBehaviour
{
    public UnityEvent OnCoinCollected;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 90 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OnCoinCollected.Invoke();
            Debug.Log("Coin gepakt!");
            //Coin destructor
            Destroy(gameObject);
         }
    }
}
