using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayButton : MonoBehaviour {


    [SerializeField]
    private PlayerControl _playerControl;

    [SerializeField]
    private DistanceText _distanceText;

    [SerializeField]
    private BarrelSpawner _spawner;

    [SerializeField]
    private GameObject _thisContainer;

    [SerializeField]
    private CoinSpawner _coinSpawner;

    [SerializeField]
    private Button Androind_Button;

    // Use this for initialization
    void Start () {
        var button = this.GetComponent<Button>();
        button.onClick.AddListener(ButtonClicked);
	}

    private void ButtonClicked()
    {
        _thisContainer.gameObject.SetActive(false);
        _playerControl.enabled = true;
        _distanceText.gameObject.SetActive(true);
        _spawner.gameObject.SetActive(true);
        _coinSpawner.gameObject.SetActive(true);
        #if UNITY_ANDROID
            Androind_Button.gameObject.SetActive(true);
        #endif
    }

    // Update is called once per frame
    void Update () {
		
	}
}
