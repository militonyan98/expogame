using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour {

    // Use this for initialization
    private float _lastTransformY;
    private Animator _currentAnimator;
	void Start () {
        _currentAnimator = GetComponent<Animator>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collide");
        if (collision.gameObject.tag == "ground")
        {

            _currentAnimator.SetBool("IsRunning", true);
            _currentAnimator.SetBool("IsJumping", false);
            _currentAnimator.SetBool("IsFalling", false);
        }
    }
}
