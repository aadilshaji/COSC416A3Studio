using UnityEngine;

public class PlayerRotationController : MonoBehaviour
{
    public Transform cameraTransform; // Reference to the camera
    public float rotationSpeed = 100f; // Adjust this for smoothness

    void Update()
    {
        if (cameraTransform != null)
        {
            // Get the camera's forward direction (ignoring vertical tilt)
            Vector3 forwardDirection = cameraTransform.forward;
            forwardDirection.y = 0; // Keep the player upright

            // Rotate player to match camera's forward direction
            if (forwardDirection != Vector3.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(forwardDirection);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }
        }
    }
}
