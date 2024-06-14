// using UnityEngine;

// public class SphereClickHandler : MonoBehaviour
// {
//     // Reference to the player GameObject to teleport
//     public GameObject playerObject;

//     // Reference to the target GameObject to move to
//     public GameObject targetObject;

//     public void OnSphereClicked()
//     {
//         if (playerObject != null && targetObject != null)
//         {
//             // Move the player object to the position of the target object
//             playerObject.transform.position = targetObject.transform.position;
//         }
        
//         Debug.Log("Sphere clicked!");
//         // Add your action here, e.g., play a sound, show a message, etc.
//     }
// }
// using UnityEngine;

// public class SphereClickHandler : MonoBehaviour
// {
//     // Reference to the player GameObject to teleport
//     public GameObject playerObject;

//     // Reference to the target GameObject to move to
//     public GameObject targetObject;

//     public void OnSphereClicked()
//     {
//          // Move the player object to the position of the target object
//          playerObject.transform.position = targetObject.transform.position;
       

//         Debug.Log("Sphere clicked!");
//         // Add your action here, e.g., play a sound, show a message, etc.
//     }
// }

using UnityEngine;

public class SphereClickHandler : MonoBehaviour
{
    // Reference to the target GameObject to move to
    public GameObject targetObject;

    public void OnSphereClicked()
    {
        GameObject playerObject = GameObject.FindWithTag("Player");
        if (playerObject != null && targetObject != null)
        {
            // Move the player object to the position of the target object
            playerObject.transform.position = targetObject.transform.position;
            Debug.Log("Sphere clicked! Player teleported.");
        }
        else
        {
            if (playerObject == null)
            {
                Debug.LogWarning("No object with tag 'Player' found!");
            }
            if (targetObject == null)
            {
                Debug.LogWarning("Target object is not assigned!");
            }
        }
    }
}

