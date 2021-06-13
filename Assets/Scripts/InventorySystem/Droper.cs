 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Droper : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private InventoryHandler _inventory;
    [SerializeField] private LootSpawner _spawner;
    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left && _inventory.Slots.DragAndDropSlot.IsFree == false)
        {
            ItemBase item = null;  
            _inventory.Slots.DragAndDropSlot.ChangeItem(ref item);

            _spawner.Spawn(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, item);

            Debug.Log("Drop");
        }

    }
}
