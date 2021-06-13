using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    [SerializeField] private ItemSlot[] _itemSlots;
    [SerializeField] private EquipmentSlot[] _equipmentSlots;

    [SerializeField] private DragAndDropSlot _dragEndDropSlot;

    public ItemSlot[] ItemSlots => _itemSlots;
    public EquipmentSlot[] EquipmentSlots => _equipmentSlots;
    public DragAndDropSlot DragAndDropSlot => _dragEndDropSlot;




 
}
