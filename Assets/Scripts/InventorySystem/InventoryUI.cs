using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private GameObject _ui;

    public void Show()
    {
        _ui.SetActive(true);
    }
    public void Hide()
    {
        _ui.SetActive(false);
    }
}
