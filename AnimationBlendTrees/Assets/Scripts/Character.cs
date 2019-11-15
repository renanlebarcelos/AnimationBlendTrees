using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.H))
        {
            _anim.SetBool("Hook", true);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            _anim.SetBool("Jab", true);
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            _anim.SetBool("CrossJab", true);
        }
    }
}