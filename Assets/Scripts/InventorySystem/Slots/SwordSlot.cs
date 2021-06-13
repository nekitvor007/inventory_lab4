using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSlot : EquipmentSlot
{
    [SerializeField] private PlayerWeapon _weapon;
    public override void ChangeBonus(ItemBase item)
    {
        _stats.AttackStat.Value -= _previouseBonus;
        if (item != null)
        {
            _previouseBonus = (item as SwordItem).Attack;
            _stats.AttackStat.Value += _previouseBonus;
        }
        _weapon.SetWeapon(item);
    }

}
