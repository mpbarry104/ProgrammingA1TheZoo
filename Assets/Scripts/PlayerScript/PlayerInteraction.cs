using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private IInteractable currentInteractable;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            currentInteractable.Interact();
            Debug.Log("Interacting with the octopus.");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Octopus")) 
        {
            currentInteractable = other.GetComponent<IInteractable>();
            Debug.Log("Entered trigger area with octopus.");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Octopus"))
        {
            currentInteractable = null;
            Debug.Log("Exited trigger area with octopus.");
        }
    }
}
