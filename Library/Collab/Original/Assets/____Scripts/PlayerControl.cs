using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerControl : MonoBehaviour {
    
    Rigidbody2D _currentRigidbody;
    Animator animator; 

    [SerializeField]
    private float _jumpScale;

    [SerializeField]
    private Button _jumpButton;

    
    private AudioSource source;

    public bool isFalling = false;
	// Use this for initialization
	void Start () {
        _currentRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        _jumpButton.onClick.AddListener(Jump);
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }

    private void Jump()
    {
        if (!animator.GetBool("IsRunning"))
            return;
        _currentRigidbody.AddForce(Vector3.up * _jumpScale, ForceMode2D.Impulse);
        animator.SetBool("IsRunning", false);
        animator.SetBool("IsJumping", true);
        animator.SetBool("IsFalling", true);
        source.Play();
    }
}
