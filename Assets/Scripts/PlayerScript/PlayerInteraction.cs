using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private IInteractable currentInteractable;
    private IRead currentInteract;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            currentInteractable.Interact();
        }
        if (Input.GetKeyDown(KeyCode.E) && currentInteract != null)
        {
            currentInteract.InteractSign();
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

        else if (other.CompareTag("Sign"))
        {
            currentInteract = other.GetComponent<IRead>();
        }

        else if (other.CompareTag("Raccoon"))
        {
            currentInteractable = other.GetComponent<IInteractable>();
        }

        else if (other.CompareTag("Gorilla"))
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

        else if (other.CompareTag("Sign"))
        {
            currentInteract = null;
        }

        else if (other.CompareTag("Raccoon"))
        {
            currentInteractable = null;
        }

        else if (other.CompareTag("Gorilla"))
        {
            currentInteractable = null;
        }
    }

}
