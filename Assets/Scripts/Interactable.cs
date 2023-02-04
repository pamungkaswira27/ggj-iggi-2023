using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Interactable : MonoBehaviour
{
    [Header("Interaction Events")]
    [SerializeField] GameObject interactBubble;
    [SerializeField] InteractType interactType;
    [SerializeField] UnityEvent onInteract;

    GameObject bubble;
    Vector2 bubbleOffsetPosition;
    bool isInRange;

    void Start()
    {
        bubbleOffsetPosition = transform.position - new Vector3(0f, -1.5f, 0f);
    }

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
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
        bubble = Instantiate(interactBubble, bubbleOffsetPosition, Quaternion.identity, transform);

        switch (interactType)
        {
            case InteractType.Talk:
                bubble.GetComponentInChildren<TextMeshProUGUI>().text = "Talk";
                break;
            case InteractType.Pickup:
                bubble.GetComponentInChildren<TextMeshProUGUI>().text = "Pickup";
                break;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        isInRange = false;
        Debug.Log("Interact Popup Hidden");
        Destroy(bubble);
    }
}

public enum InteractType
{
    Talk,
    Pickup
}
