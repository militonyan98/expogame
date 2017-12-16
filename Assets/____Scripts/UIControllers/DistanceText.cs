using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceText : MonoBehaviour {

    [SerializeField]
    private float _multiplier = 8f;

    [SerializeField]
    private Text _finalScore;

    private float _distance = 0f;

    private Text _currentText;

    private bool _isPaused;

    private const string MESSAGE = "DISTANCE: {0}m";

	// Use this for initialization
	void Start () {
        _isPaused = false;
        _currentText = this.GetComponent<Text>();
	}

    private void OnEnable()
    {
        ResetDistance();
    }

    public void Pause()
    {
        _isPaused = true;
    }

    // Update is called once per frame
    void Update () {
        if (_isPaused)
            return;
        _distance += Time.deltaTime * _multiplier;
        UpdateText();
	}

    private void UpdateText()
    {
        _currentText.text = String.Format(MESSAGE, Math.Floor(_distance));
        _finalScore.text = _currentText.text;
    }

    public void ResetDistance()
    {
        _distance = 0;
    }

    internal void Add100()
    {
        _distance += 100;
    }
}
