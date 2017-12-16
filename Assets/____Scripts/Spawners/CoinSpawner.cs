using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class CoinSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject _coin;

    [SerializeField]
    private float _minTime = 1.5f;

    [SerializeField]
    private float _maxTime = 3.0f;

    private float _currentTime;

    // Use this for initialization
    void Start()
    {
        _currentTime = Random.Range(_minTime, _maxTime);

        StartCoroutine(DeployCoin());
    }

    private IEnumerator DeployCoin()
    {
        yield return new WaitForSeconds(_currentTime);

        var cur = Instantiate(_coin) as GameObject;

        _currentTime = Random.Range(_minTime, _maxTime);

        StartCoroutine(DeployCoin());

    }
}