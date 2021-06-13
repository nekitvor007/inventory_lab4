using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackItem<TSlot> : EquipmentItem where TSlot : Slot
{
    [SerializeField] private float _attack;
    public float Attack => _attack;

    public override bool CheckForType(Slot slot)
    {
        return slot is TSlot || slot is ItemSlot || slot is DragAndDropSlot;
    }
}
