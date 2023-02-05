using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] InventoryItemSO inventoryItem;

    public void AddItem(InventoryItemSO item)
    {
        inventoryItem = item;
    }

    public void RemoveItem(InventoryItemSO item)
    {
        inventoryItem = null;
    }

    public bool CheckItem(InventoryItemSO item)
    {
        return inventoryItem.GetItemId().Equals(item.GetItemId());
    }

    public void DisplayItem()
    {
        GetComponentsInChildren<Image>()[1].sprite = inventoryItem.GetItemIcon();
    }
}
