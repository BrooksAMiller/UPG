using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskList : MonoBehaviour
{

    PickUpScript pus = new PickUpScript();

    public GameObject taskUI;
    public Toggle walkCheckBox;
    public Toggle pickUpCheckBox;

    
    
    public static bool paused = false;

    public Transform pigPickUpLocation;
    public Transform swordLocation;

    private bool walkingTask = false;
    private bool pickUpTask = false;
    private bool pressedW = false;
    private bool pressedA = false;
    private bool pressedS = false;
    private bool pressedD = false;

    // Update is called once per frame
    void Update()
    {
        MenuLogic();

        //Debug.Log(pus.location.position);

        if (walkingTask == false)
        {
            WalkingTask();
        }

        if (pickUpTask == false)
        {
            PickUpTask();
        }
        
    }

    public void MenuLogic()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (paused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    public void Resume()
    {
        taskUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }
    public void Paused()
    {
        taskUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }
    public void WalkingTask()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            pressedW = true;
        } 
        else if (Input.GetKeyDown(KeyCode.A))
        {
            pressedA = true;
        } 
        else if (Input.GetKeyDown(KeyCode.S))
        {
            pressedS = true;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            pressedD = true;
        } 
        else if (pressedW == true && pressedA == true && pressedS == true && pressedD == true)
        {
            WalkingTaskCompleted();
        }

    }

    public void WalkingTaskCompleted()
    {
        Debug.Log("Walking task complete");
        walkCheckBox.isOn = true;
        walkingTask = true;
    }

    public void PickUpTask()
    {
        if (swordLocation.position == pigPickUpLocation.position)
        {
            PickUpTaskCompleted();
        }
    }

    public void PickUpTaskCompleted()
    {
        Debug.Log("Pick up task completed");
        pickUpCheckBox.isOn = true;
        pickUpTask = true;
    }




}
