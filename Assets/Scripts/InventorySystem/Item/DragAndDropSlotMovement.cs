using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(RectTransform))]
public class DragAndDropSlotMovement : MonoBehaviour
{
    private Canvas _canvas;
    private Camera _canvasCamera;
    private RectTransform _canvasTransform;
    private Vector2 _position;


    private void Awake()
    {
        _canvas = GetComponentInParent<Canvas>();
        _canvasTransform = _canvas.transform as RectTransform;
        _canvasCamera = _canvas.worldCamera;
    }

    private void Update()
    {
        FollowMouse();
    }

    private void FollowMouse()
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(_canvasTransform, Input.mousePosition, _canvasCamera, out _position);
        transform.position = _canvas.transform.TransformPoint(_position);
    }
}
