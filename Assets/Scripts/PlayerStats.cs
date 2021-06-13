using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public Stat AttackStat { get; private set; } = new Stat(0);
    public Stat DefenseStat { get; private set; } = new Stat(0);

}
