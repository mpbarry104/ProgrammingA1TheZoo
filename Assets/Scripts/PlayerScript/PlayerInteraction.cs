using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private IInteractable currentInteractable;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            currentInteractable.Interact();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Octopus")) 
        {
            currentInteractable = other.GetComponent<IInteractable>();
        }
            
        else if (other.CompareTag("Penguin")) 
        {
            currentInteractable = other.GetComponent<IInteractable>();
        }
    
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Octopus"))
        {
            currentInteractable = null;
        }
        else if (other.CompareTag("Penguin"))
        {
            currentInteractable = null;
        }
    }
    
}
