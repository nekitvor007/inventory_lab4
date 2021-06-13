using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHandler : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private InventoryUI _UI;
    [SerializeField] private KeyCode _showKey;

    public Inventory Slots => _inventory;

    private bool _isShowing = false;

    private void Update()
    {
        if (Input.GetKeyDown(_showKey))
        {
            _isShowing = !_isShowing;
            if (_isShowing)
            {
                Show();
            }
            else
            {
                Hide();
            }
        }

    }

    public ItemBase SetEquipment(ItemBase item)
    {
        for (int i = 0; i < _inventory.EquipmentSlots.Length; i++)
        {
            if (_inventory.EquipmentSlots[i].ChangeItem(ref item))
            {
                break;
            }
        }
        return item;
    }

    public bool TryAddItem(ItemBase item)
    {
        for (int i = 0; i < _inventory.EquipmentSlots.Length; i++)
        {
            if (_inventory.EquipmentSlots[i].TrySetItem(item) == true)
            {
                return true;
            }
        }

        for (int i = 0; i < _inventory.ItemSlots.Length; i++)
        {
            if (_inventory.ItemSlots[i].TrySetItem(item) == true)
            {
                return true;
            }
        }

        return false;
    }

    private void Show()
    {
        _UI.Show();
    }
    private void Hide()
    {
        _UI.Hide();
    }



}
