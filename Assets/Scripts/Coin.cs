using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 10;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddScore(value);
            Destroy(gameObject);
        }
    }
}