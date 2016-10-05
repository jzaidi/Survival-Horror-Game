using UnityEngine;
using System.Collections;


public class Flashlight : MonoBehaviour
{


    public Light flashLight;


    public bool isActive;

    // Use this for initialization
    void Start()
    {
        isActive = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isActive == false)
            {
                flashLight.enabled = true;
                isActive = true;
            }
            else if (isActive == true)
            {
                flashLight.enabled = false;
                isActive = false;
            }
        }
    }


}

