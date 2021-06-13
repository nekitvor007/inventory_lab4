using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EquipmentSlot : Slot
{
    [SerializeField] protected PlayerStats _stats;
    protected float _previouseBonus = 0f;

    private void Start()
    {
        ItemChanged += ChangeBonus;
    }

    public abstract void ChangeBonus(ItemBase item);
}
