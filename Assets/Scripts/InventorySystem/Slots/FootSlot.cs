using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSlot : EquipmentSlot
{
    public override void ChangeBonus(ItemBase item)
    {

        _stats.DefenseStat.Value -= _previouseBonus;
        if (item != null)
        {
            _previouseBonus = (item as FootItem).Defence;
            _stats.DefenseStat.Value += _previouseBonus;
        }
    }

}
