using UnityEngine;

public class SphereClickHandler : MonoBehaviour
{
    // Reference to the player GameObject to teleport
    public GameObject playerObject;

    // Reference to the target GameObject to move to
    public GameObject targetObject;

    public void OnSphereClicked()
    {
        if (playerObject != null && targetObject != null)
        {
            // Move the player object to the position of the target object
            playerObject.transform.position = targetObject.transform.position;
        }
        
        Debug.Log("Sphere clicked!");
        // Add your action here, e.g., play a sound, show a message, etc.
    }
}
