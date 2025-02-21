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

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Octopus"))
        {
            currentInteractable = other.GetComponent<IInteractable>();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Octopus"))
        {
            currentInteractable = null;
        }
    }
}
