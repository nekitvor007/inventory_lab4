using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DefenseItem<TSlot> : EquipmentItem where TSlot : Slot
{
    [SerializeField] private float _defence;
    public float Defence => _defence;

    public override bool CheckForType(Slot slot)
    {
        return slot is TSlot || slot is ItemSlot || slot is DragAndDropSlot;
    }
}
