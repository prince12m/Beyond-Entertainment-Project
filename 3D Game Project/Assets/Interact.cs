using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    bool isInteractable = false;

    void Update()
    {
        if (isInteractable == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Stuff happens here
                Debug.Log("Interact");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("!!!!!");
            isInteractable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInteractable = false;
        }
    }
}
