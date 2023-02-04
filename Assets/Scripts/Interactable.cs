using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    [Header("Interaction Events")]
    [SerializeField] UnityEvent onInteract;
    bool isInRange;

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("Hello...");
                onInteract?.Invoke();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        isInRange = true;
        Debug.Log("Interact Popup Shown");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        isInRange = false;
        Debug.Log("Interact Popup Hidden");
    }
}
