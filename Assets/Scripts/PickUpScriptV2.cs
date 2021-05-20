using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScriptV2 : MonoBehaviour
{
    public Transform location;
    public Material highlightColor;
    public GameObject player;
    public GameObject particles;

    private void Start()
    {
        
  

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
            //this.GetComponent<ParticleSystem>().Play();
            Debug.Log("Close!");
            particles.SetActive(true);

        }
        else if (dist > 3 && dist > 6)
        {
            //this.GetComponent<ParticleSystem>().Stop();
            Debug.Log("Far");
            particles.SetActive(false);

        }
    }
}
