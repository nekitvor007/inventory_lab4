using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPicker : MonoBehaviour
{
    [SerializeField] private InventoryHandler _inventory;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.TryGetComponent(out Loot pickable))
        {
            _inventory.TryAddItem(pickable.Item);
            Destroy(collider.gameObject);
        }
    }
}
