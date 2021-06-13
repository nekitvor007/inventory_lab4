using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New item", menuName = "Items/Item", order = 1)]
public class Item : ItemBase
{
    public override bool CheckForType(Slot slot)
    {
        return slot is ItemSlot || slot is DragAndDropSlot;
    }
}
