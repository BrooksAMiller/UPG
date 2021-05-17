using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScriptV2 : MonoBehaviour
{
    public Transform location;
    public Material highlightColor;
    public GameObject player;

    private void Start()
    {
        this.GetComponent<ParticleSystem>().Stop();

    }


    private void Update()
    {
        HighlightCheck();
    }

    

    private void HighlightCheck()
    {
        float dist = Vector3.Distance(player.transform.position, this.transform.position);
        if(dist < 3)
        {
            Debug.Log("Close!");
            this.GetComponent<ParticleSystem>().Play();
        }
        else if (dist > 3 && dist > 6)
        {
            this.GetComponent<ParticleSystem>().Stop();
            Debug.Log("Far");
        }
    }
}
