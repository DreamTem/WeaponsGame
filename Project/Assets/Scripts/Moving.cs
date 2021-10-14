using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private bool _startedAudio = false;
    private float _movingInp;
    public float speed;

    private AudioSource _aS;
    private Rigidbody _rb;
    private Animator _anim;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _aS = GetComponent<AudioSource>();
        _anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _movingInp = Input.GetAxis("Vertical");
        _rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime * _movingInp);
    }
    void Update(){
        if(_movingInp != 0 && !_startedAudio){
            _aS.Play();
            _startedAudio = true;
            _anim.SetBool("Moving", true);
        }
        else if(_movingInp == 0){
            _aS.Stop();
            _startedAudio = false;
            _anim.SetBool("Moving", false);
        }
    }
}
