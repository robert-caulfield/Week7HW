using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(cam.transform.position, Camera.main.transform.forward, out hit, 100.0f))
            {
                if(hit.transform.gameObject.tag == "Interact")
                {
                    hit.transform.GetComponent<Interactable>().onInteract();
                }
            }


        }
    }
}
