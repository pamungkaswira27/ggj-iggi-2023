using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] InventoryItemSO inventoryItem;
    Inventory inventory;

    void Awake()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    public void PickItem()
    {
        inventory.AddItem(inventoryItem);
        inventory.DisplayItem();
        gameObject.SetActive(false);
    }
}
