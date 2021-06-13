using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;

    public void SetWeapon(ItemBase item)
    {
        if (item != null)
        {
            _spriteRenderer.sprite = item.Sprite;
        }
        else
        {
            _spriteRenderer.sprite = null;
        }
    }
}