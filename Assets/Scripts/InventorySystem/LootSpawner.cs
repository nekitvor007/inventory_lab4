using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootSpawner : MonoBehaviour
{
    [SerializeField] private Loot _prefab;
    [SerializeField] private float y;
    public void Spawn(float x, ItemBase item)
    {
        Instantiate(_prefab, new Vector2(x, y), Quaternion.identity).SetItem(item);
    }
}
