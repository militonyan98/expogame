using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour {


    [SerializeField]
    private DistanceText _distanceText;

    [SerializeField]
    private GameObject _gameOver;

    [SerializeField]
    private BarrelSpawner _spawner;

    [SerializeField]
    private CoinSpawner _coinSpawner;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Barrel>()!=null)
        {
            Debug.Log("You dead");
            _gameOver.SetActive(true);
            _distanceText.Pause();
            _distanceText.gameObject.SetActive(false);
            this.gameObject.GetComponent<PlayerControl>().enabled = false;
            _spawner.gameObject.SetActive(false);
            _coinSpawner.gameObject.SetActive(false);

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _distanceText.Add100();
        Destroy(other.gameObject);
    }
}
