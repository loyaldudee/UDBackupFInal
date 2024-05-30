using UnityEngine;

public class CameraFollowSpectating : MonoBehaviour
{
    public Transform target; // Reference to the target object (main player)

    [SerializeField] private Vector3 offset = new Vector3(0f, 1.5f, -3f); // Offset from the target object
    [SerializeField] private float smoothSpeed = 10f; // Smoothing speed for camera movement

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position of the camera
            Vector3 desiredPosition = target.position + offset;
            // Smoothly move the camera towards the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;

            // Make the camera look at the target object
            transform.LookAt(target);
        }
    }
}
