using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(button.spike == true)
        {
            DestroyGameObject();
        }
    }
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
