using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStatsUI : MonoBehaviour
{
    [SerializeField] private PlayerStats _stats;

    [SerializeField] private TextMeshProUGUI _defenseText;
    [SerializeField] private TextMeshProUGUI _attackText;


    private void OnEnable()
    {
        ChangeDefenseText(_stats.DefenseStat.Value);

        ChangeAttackText(_stats.AttackStat.Value);

        _stats.DefenseStat.Changed += ChangeDefenseText;
        _stats.AttackStat.Changed += ChangeAttackText;
    }

    private void OnDestroy()
    {
        _stats.DefenseStat.Changed -= ChangeDefenseText;
        _stats.AttackStat.Changed -= ChangeAttackText;
    }

    private void ChangeDefenseText(float value)
    {
        _defenseText.SetText("Defense: " + value);
    }

    private void ChangeAttackText(float value)
    {
        _attackText.SetText("Attack: " + value);
    }
}
