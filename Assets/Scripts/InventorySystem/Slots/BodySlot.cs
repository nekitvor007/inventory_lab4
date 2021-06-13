using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySlot : EquipmentSlot
{
    public override void ChangeBonus(ItemBase item)
    {
        _stats.DefenseStat.Value -= _previouseBonus;

        if (item != null)
        {
            _previouseBonus = (item as BodyItem).Defence;
            _stats.DefenseStat.Value += _previouseBonus;
        }
    }

}
