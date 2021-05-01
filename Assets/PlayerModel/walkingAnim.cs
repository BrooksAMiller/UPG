using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingAnim : MonoBehaviour
{
     Animator a;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.D))
        {
            a.SetBool("moving", true);
        }
        else
        {
             a.SetBool("moving", false);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            a.SetBool("isJumping", true);
        }
        else
        {
            a.SetBool("isJumping", false);
        }

        if (Input.GetKey(KeyCode.E))
        {
            a.SetBool("isRunning", true);
        }
        else
        {
            a.SetBool("isRunning", false);
        }
    }
}
