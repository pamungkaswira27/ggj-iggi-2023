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
        AudioManager.Instance.PlayItemPickedUpSFX();
        inventory.AddItem(inventoryItem);
        inventory.DisplayItem();
        gameObject.SetActive(false);
    }
}
