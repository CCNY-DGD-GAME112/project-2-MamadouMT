using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winScreen;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winScreen.SetActive(true);
        }
    }
}
