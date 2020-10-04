using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class animatorStateController : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public GameObject camera;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            UnityEngine.Debug.Log(Vector3.Distance(camera.transform.position, this.transform.position));
            animator.SetBool("isWalking", false);
            if(Vector3.Distance(camera.transform.position, this.transform.position) <= 0.3f)
            {
                animator.SetBool("isWalking", true);
            }
    }
}
