using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class button : MonoBehaviour
{
    [SerializeField] AudioSource buttonSound;  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public static bool spike = false;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            spike = true;
            buttonSound.Play();
        }
    }
}
