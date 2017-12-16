using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;
public class BarrelSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject _barrel;

    [SerializeField]
    private float _minTime= 1.5f;

    [SerializeField]
    private float _maxTime = 3.0f;

    private float _currentTime;

	// Use this for initialization
	void Start () {
        _currentTime = Random.Range(_minTime, _maxTime);

        StartCoroutine(DeployBarrel());
	}

    private IEnumerator DeployBarrel()
    {
        yield return new WaitForSeconds(_currentTime);

        var cur = Instantiate(_barrel) as GameObject;

        _currentTime = Random.Range(_minTime, _maxTime);

        StartCoroutine(DeployBarrel());

    }
}
