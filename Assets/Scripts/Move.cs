using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController controller;
    public Transform cam;


    public float speed = 6f;


    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0f, v).normalized;

        if (dir.magnitude >= 0.1f)
        {

            float directionAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0f, directionAngle, 0f);

            Vector3 moveWithCamera = Quaternion.Euler(0f, directionAngle, 0f) * Vector3.forward;

            controller.Move(moveWithCamera.normalized * speed * Time.deltaTime);
        }
    }
}