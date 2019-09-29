using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Vertices : MonoBehaviour
{
    private Renderer[] _vertexShader;
    private float _extrusionAmount = 0f;
    private int _countdown;

    private void Start()
    {
        _vertexShader = GetComponentsInChildren<Renderer>();

        _countdown = 60;
    }

    private void Update()
    {
        _countdown--;
        if (_countdown <= 0)
        {
            _extrusionAmount -= 0.001f;
            _countdown = 120;
            Debug.Log(_extrusionAmount);
            for (int i = 0; i < _vertexShader.Length; i++)
            {
                _vertexShader[i].material.SetFloat("_Amount", _extrusionAmount);
            }
        }

        if (_extrusionAmount <= -0.01f)
        {
            _extrusionAmount = -0.01f;
            for (int i = 0; i < _vertexShader.Length; i++)
            {
                _vertexShader[i].material.SetFloat("_Amount", _extrusionAmount);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Food")
        {
            _extrusionAmount += 0.001f;
            for (int i = 0; i < _vertexShader.Length; i++)
            {
                _vertexShader[i].material.SetFloat("_Amount", _extrusionAmount);
            }
            Destroy(other.gameObject);
        }
    }
}
