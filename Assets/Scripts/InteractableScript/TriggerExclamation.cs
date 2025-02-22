using UnityEngine;

public class TriggerAppear2D : MonoBehaviour
{
    public GameObject objectToAppear;

    private void OnTriggerEnter2D(Collider2D other)
    {
    
        if (other.CompareTag("Player"))
        {
         
            objectToAppear.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            objectToAppear.SetActive(false);
        }
    }
}
