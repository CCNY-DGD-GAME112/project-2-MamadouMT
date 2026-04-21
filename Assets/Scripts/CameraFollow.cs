using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;      // drag player here
    public Vector3 offset;        // distance from player

    void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}