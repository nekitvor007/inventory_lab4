using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    [field: SerializeField] public ItemBase Item { get; private set; }

    
    private SpriteRenderer _spriteRender;

    private void Awake()
    {
        _spriteRender = GetComponent<SpriteRenderer>();
        _spriteRender.sprite = Item?.Sprite;   
    }

    public void SetItem(ItemBase item)
    {
        _spriteRender.sprite = item?.Sprite;
        Item = item;
    }

}
