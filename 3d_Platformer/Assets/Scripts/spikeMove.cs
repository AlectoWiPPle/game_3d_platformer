using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spikeMove : MonoBehaviour
{
    private Vector3 cubePosition;
    // Start is called before the first frame update
    void Start()
    {
        cubePosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(button.spike == true)
        {
            cubePosition = new Vector3(1,-5,56);
        }
        this.transform.position = cubePosition;
    }
}
