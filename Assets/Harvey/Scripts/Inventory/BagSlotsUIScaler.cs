using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GridLayoutGroup))]
public class BagSlotsUIScaler : MonoBehaviour
{
    GridLayoutGroup gridLayoutGroup;

    RectTransform rectTransform;

    [SerializeField] InventoryGrouper inventoryGrouper;

    [SerializeField] Transform bagSlotPrefeb;

    [SerializeField] Inventory playerInventory;

    void Awake()
    {
        // Initialize
        gridLayoutGroup = GetComponent<GridLayoutGroup>();

        rectTransform = GetComponent<RectTransform>();
    }

    void OnEnable()
    {
        // Calculate the bag slot's position in the scene
        rectTransform.anchoredPosition = new Vector2(-bagSlotPrefeb.GetComponent<RectTransform>().sizeDelta.x * 1.1f, inventoryGrouper.GetComponent<RectTransform>().anchoredPosition.y);

        // Instantiate a bag slot gameObject for every bag slot
        for (int i = 0; i < playerInventory.bags.Count; i++)
        {
            Instantiate(bagSlotPrefeb, transform);
        }
    }

    void OnDisable()
    {
        // Destory all child gameObject
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
