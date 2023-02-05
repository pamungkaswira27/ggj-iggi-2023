using UnityEngine;

[CreateAssetMenu(menuName = "Inventory/Item", fileName = "Item")]
public class InventoryItemSO : ScriptableObject
{
    [SerializeField] string itemId;
    [SerializeField] GameObject itemPrefab;

    public string GetItemId()
    {
        return itemId;
    }

    public GameObject GetItemPrefab()
    {
        return itemPrefab;
    }

    public Sprite GetItemIcon()
    {
        return itemPrefab.GetComponent<SpriteRenderer>().sprite;
    }
}
