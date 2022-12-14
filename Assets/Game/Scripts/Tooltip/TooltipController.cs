using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class TooltipController : MonoBehaviour
{
    int UILayer;
    [SerializeField] TooltipUI tooltipUI;

    void Start()
    {
        // Initialize
        UILayer = LayerMask.NameToLayer("UI");
    }

    void Update()
    {
        // See if the mouse is over an UI element
        // Probably should have a function to handle all of these
        GameObject uiGameObject = IsPointerOverUIElement(GetEventSystemRaycastResults());

        // If there is an UI gameObject
        if (uiGameObject != null)
        {
            // If that UI gameObject is a menu button
            if (uiGameObject.GetComponent<MenuButtonClassifier>() != null)
            {
                // Ask tooltip UI to display tooltip text
                tooltipUI.SetText(uiGameObject.GetComponent<MenuButtonClassifier>().tooltipText);
                tooltipUI.UpdateTooltipPosition();
                tooltipUI.gameObject.SetActive(true);
            }
            // If that UI gameObject is an inventory slot and the inventory slot is holding an item
            else if (uiGameObject.GetComponent<DragDrop>() != null)
            {
                if (uiGameObject.transform.parent.GetComponent<InventorySlot>().slottedItem != null)
                {
                    // Cache the slotted item
                    Item slottedItem = uiGameObject.transform.parent.GetComponent<InventorySlot>().slottedItem;

                    // Ask tooltip UI to display tooltip text
                    string tooltipText = slottedItem.name + "\n" + slottedItem.description;
                    if (slottedItem.tooltipText != string.Empty)
                    {
                        tooltipText = tooltipText + "\n" + slottedItem.tooltipText;
                    }

                    tooltipUI.SetText(tooltipText);
                    tooltipUI.UpdateTooltipPosition();
                    tooltipUI.gameObject.SetActive(true);
                }
            }
            // If that UI gameObject is an equipment slot and the equipment slot is holding an item
            else if (uiGameObject.GetComponent<EquipmentSlotController>() != null)
            {
                // If the equipment slot is holding an item
                if (uiGameObject.GetComponent<EquipmentSlotController>().targetSlot.equipment != null)
                {
                    // Cache the equipment
                    Equipment equipment = uiGameObject.GetComponent<EquipmentSlotController>().targetSlot.equipment;

                    // Ask tooltip UI to display tooltip text
                    string tooltipText = equipment.name + "\n" + equipment.description;

                    tooltipUI.SetText(tooltipText);
                    tooltipUI.UpdateTooltipPosition();
                    tooltipUI.gameObject.SetActive(true);
                }
                else
                {
                    // Ask tooltip UI to hide the tooltip text
                    tooltipUI.gameObject.SetActive(false);
                }
            }
            else
            {
                // Ask tooltip UI to hide the tooltip text
                tooltipUI.gameObject.SetActive(false);
            }
        }
        // If the player is not hovering UI
        else
        {
            // Ask tooltip UI to hide the tooltip text
            tooltipUI.gameObject.SetActive(false);
        }
    }

    // Method to get the reference to a UI element that the mouse is hovering
    private GameObject IsPointerOverUIElement(List<RaycastResult> eventSystemRaysastResults)
    {
        for (int index = 0; index < eventSystemRaysastResults.Count; index++)
        {
            // Cache the raycast result
            RaycastResult curRaysastResult = eventSystemRaysastResults[index];

            // If that gameObject is on the UI layer
            if (curRaysastResult.gameObject.layer == UILayer)
            {
                // Return the Ui gameObject
                return curRaysastResult.gameObject;
            }
        }
        // Return null, meaning the gameObject is not from the UI layer
        return null;
    }

    // Gets all event system raycast results of current mouse position.
    static List<RaycastResult> GetEventSystemRaycastResults()
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);

        eventData.position = Mouse.current.position.ReadValue();

        List<RaycastResult> raysastResults = new List<RaycastResult>();

        EventSystem.current.RaycastAll(eventData, raysastResults);

        return raysastResults;
    }
}
