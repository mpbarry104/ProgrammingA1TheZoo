using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private IInteractable currentInteractable;

    void Update()
    {
        // When the player presses E and there is an interactable object in range
        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            currentInteractable.Interact();
            Debug.Log("Interacting with the octopus.");
        }
    }

    // This method will be triggered when the player enters the trigger area of the octopus
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Octopus"))  // Ensure the Octopus has the "Octopus" tag
        {
            currentInteractable = other.GetComponent<IInteractable>();
            Debug.Log("Entered trigger area with octopus.");
        }
    }

    // This method will be triggered when the player leaves the trigger area of the octopus
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Octopus"))
        {
            currentInteractable = null;
            Debug.Log("Exited trigger area with octopus.");
        }
    }
}
