using UnityEngine;
using UnityEngine.UI;


public class SignInteraction2D : MonoBehaviour, IInteractable
{
    public GameObject textUI;
    private bool playerInRange = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            textUI.SetActive(!textUI.activeSelf); 
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            textUI.SetActive(false);
        }
    }

    public void Interact()
    {
        Debug.Log("You Read the sign.");
    }
}
