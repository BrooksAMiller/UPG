using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public Transform location;

        void OnMouseDown()
        {
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = location.position;
        }

        void OnMouseUp()
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }   

