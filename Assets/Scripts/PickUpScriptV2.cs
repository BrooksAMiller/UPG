using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScriptV2 : MonoBehaviour
{
    public Transform location; //Where the center of the object will go if picked up
    public Material highlightColor;
    public GameObject player;
    public GameObject particles;
    private bool isHighlighted;

    private void Start()
    {
        
  

    }


    private void Update()
    {
        HighlightCheck();

        if (isHighlighted == true)
        {

            if (Input.GetMouseButton(0))
            {
                PickUp();
                Component halo = GetComponent("Halo");
                halo.GetType().GetProperty("enabled").SetValue(halo, false, null);

            }
        }
        
    }

    

    private void HighlightCheck()
    {
        float dist = Vector3.Distance(player.transform.position, this.transform.position);
        if(dist < 3)
        {
            //Debug.Log("Close!");
            //particles.SetActive(true);

            Component halo = GetComponent("Halo");
            halo.GetType().GetProperty("enabled").SetValue(halo, true, null);
            isHighlighted = true;

        }
        else if (dist > 3 && dist > 6)
        {
            //Debug.Log("Far");
            //particles.SetActive(false);

            Component halo = GetComponent("Halo");
            halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
            isHighlighted = false;

        }
    }

    private void PickUp()
    {
        this.gameObject.transform.position = location.position;
    }

    private void PickupCheck()
    {

    }
}
