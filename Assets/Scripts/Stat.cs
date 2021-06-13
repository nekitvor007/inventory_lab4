using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat
{
    public float Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value = Mathf.Clamp(value, _minValue, _maxValue);
            Changed?.Invoke(_value);
        }
    }

    public event Action<float> Changed;


    private float _value = 0;
    private readonly float _maxValue = 100;
    private readonly float _minValue = 0;

    public Stat(float minValue, float maxValue, float startValue)
    {
        _maxValue = maxValue;
        _minValue = minValue;
        Value = startValue;
    }

    public Stat(float startValue)
    {
        Value = startValue;
    }

}
