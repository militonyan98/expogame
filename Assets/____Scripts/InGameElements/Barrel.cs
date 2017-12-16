using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour {


    [SerializeField]
    private float _translateMagnitude = 7.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector2.left * _translateMagnitude * Time.deltaTime);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "destroyer")
        {
            Destroy(this.gameObject);
        }
    }
}
