using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpUI : MonoBehaviour{

    public Text pickUpCanvas;
    public GameObject sphere;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = sphere.transform.position;
        pickUpCanvas.transform.position = position;
        
    }
}
