using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Player's transform
    public float smoothing = 5f; // Smoothing speed
    public Vector3 offset; // Offset from the player

    private void Start()
    {
        // Calculate initial offset
        offset = transform.position - player.position;
    }

    private void FixedUpdate()
    {
        // Target position is player position plus the offset
        Vector3 targetPosition = player.position + offset;

        // Smoothly move the camera towards the target position
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);
    }
}
