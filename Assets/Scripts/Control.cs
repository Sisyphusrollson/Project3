using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Control : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private GameObject animatedObj;
    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKeyDown("space"))
        {
            playerRigidbody.AddForce(0, 1000, 0);
        }
        if (Input.GetKeyDown("d"))
        {
            playerRigidbody.AddForce(1000, 0, 0);
        }
        if (Input.GetKeyDown("s"))
        {
            playerRigidbody.AddForce(0, 0, 1000);
        }
        if(Input.GetKey("w"))
        {
            animatedObj.SetActive(true);
            playerRigidbody.AddRelativeForce(Vector3.forward * 5);
        }
        else
        {
            animatedObj.SetActive(false);
        }
    }
}
