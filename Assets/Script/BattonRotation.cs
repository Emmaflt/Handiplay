using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattonRotation : MonoBehaviour
{
    public GameObject stick;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("non");
           
        }
    }
}