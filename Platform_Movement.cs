using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using Debug = UnityEngine.Debug;


public class Platform_Movement : MonoBehaviour
{
    void Update()
    {
        if (GameObject.Find("Main Camera").GetComponent<Pause_Menu>().arrowKeys)
        {

            if (Input.GetKey("up") == true)
            {
                transform.Translate(0f, -5f * Time.deltaTime, 0f);
                //Debug.Log("Up arrow was pressed.");
            }

            if (Input.GetKey("down") == true)
            {
                transform.Translate(0f, 5f * Time.deltaTime, 0f);
                //Debug.Log("Down arrow was pressed.");
            }

            if (Input.GetKey("right") == true)
            {
                transform.Translate(5f * Time.deltaTime, 0f, 0f);
                //Debug.Log("Right arrow was pressed.");
            }

            if (Input.GetKey("left") == true)
            {
                transform.Translate(-5f * Time.deltaTime, 0f, 0f);
                //Debug.Log("Left arrow was pressed.");
            }

        }
        else
        {
            if (Input.GetKey("w") == true)
            {
                transform.Translate(0f, -5f * Time.deltaTime, 0f);
                //Debug.Log("Up arrow was pressed.");
            }

            if (Input.GetKey("s") == true)
            {
                transform.Translate(0f, 5f * Time.deltaTime, 0f);
                //Debug.Log("Down arrow was pressed.");
            }

            if (Input.GetKey("d") == true)
            {
                transform.Translate(5f * Time.deltaTime, 0f, 0f);
                //Debug.Log("Right arrow was pressed.");
            }

            if (Input.GetKey("a") == true)
            {
                transform.Translate(-5f * Time.deltaTime, 0f, 0f);
                //Debug.Log("Left arrow was pressed.");
            }
        }

    }

}