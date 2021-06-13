using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class Slot : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] protected Image _image;

    public bool IsFree => Item == null;
    public ItemBase Item { get; private set; }

    public event Action<ItemBase> ItemChanged;
    
    private InventoryHandler _inventory;

    private void Awake()
    {
        _inventory = FindObjectOfType<InventoryHandler>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ItemBase item;
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (IsFree == false)
            {
                item = _inventory.SetEquipment(Item);
                ChangeItem(ref item);
            }
        }
        else if (eventData.button == PointerEventData.InputButton.Left)
        {

            if (_inventory.Slots.DragAndDropSlot.IsFree)
            {
                if (Item == null)
                {
                    return;
                }
                item = Item;
                _inventory.Slots.DragAndDropSlot.ChangeItem(ref item);
                ChangeItem(ref item);
            }
            else
            {
                item = _inventory.Slots.DragAndDropSlot.Item;
                ChangeItem(ref item);
                _inventory.Slots.DragAndDropSlot.ChangeItem(ref item);
            }
        }
    }
    public bool ChangeItem(ref ItemBase item)
    {
        if (item == null || item.CheckForType(this))
        {
            ItemBase old = Item;
            Item = item;
            item = old;
            if (Item != null)
            {
                ShowNewImage(Item.Sprite);
            }
            else
            {
                ClearSlot();
            }
            ItemChanged?.Invoke(Item);
            return true;
        }
        return false;
    }
    public  bool TrySetItem(ItemBase item)
    {
        if (IsFree && item.CheckForType(this))
        {
            Item = item;
            if (item != null)
            {
                ShowNewImage(item.Sprite);
            }
            ItemChanged?.Invoke(Item);
            return true;
        }
        return false;
    }

    public void ShowNewImage(Sprite sprite)
    {
        _image.sprite = sprite;
        _image.color = new Color(1, 1, 1, 1);
    }

    public void ClearSlot()
    {
        _image.color = new Color(1, 1, 1, 0);
        Item = null;
    }

    

}
