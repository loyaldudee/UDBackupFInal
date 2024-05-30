using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRInteract : MonoBehaviour
{
    [SerializeField] private Transform raycastSource; // Transform to use for raycasting
    [SerializeField] private float rayLength = 10f;

    private void Update()
    {
        if (raycastSource != null && Input.GetButtonDown("Fire1")) // Change "Fire1" to the input you want to use for triggering interaction
        {
            RaycastHit hit;
            if (Physics.Raycast(raycastSource.position, raycastSource.forward, out hit, rayLength))
            {
                SphereClickHandler sphereClickHandler = hit.collider.GetComponent<SphereClickHandler>();
                if (sphereClickHandler != null)
                {
                    sphereClickHandler.OnSphereClicked();
                }
            }
        }
    }
}
